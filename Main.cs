using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace SpeedLine
{
    public partial class Main : Form
    {
        delegate void SetTextCallback(string text);

        private Dictionary<int, List<string>> allDatas = new Dictionary<int, List<string>>();
        private Dictionary<int, List<string>> searchDatas = new Dictionary<int, List<string>>();
        private int part = 0;
        private int page = 0;
        private int spart = 0;
        private int spage = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "请选择要读取的文本文件";
            openFile.Multiselect = false;
            openFile.Filter = "文本文件|*.txt|所有文件|*.*";
            openFile.ShowDialog();

            string path = openFile.FileName;
            if (path == "")
                return;

            using (StreamReader sr = new StreamReader(path))
            {
                int i = 0;
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (!allDatas.ContainsKey(i))
                        allDatas[i] = new List<string>();
                    if (allDatas[i].Count + 1 > int.MaxValue)
                    {
                        allDatas[++i] = new List<string>();
                    }

                    allDatas[i].Add(line);
                }
            }

            AddText();
        }

        private void Spilt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "请选择要分割的文本文件(每份128MB)";
            openFile.Multiselect = false;
            openFile.Filter = "文本文件|*.txt|所有文件|*.*";
            openFile.ShowDialog();

            string path = openFile.FileName;
            if (path == "")
                return;

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            var name = path.Substring(path.LastIndexOf("\\") + 1);
            name = name.Substring(0, name.LastIndexOf(".")); 
            path = path.Substring(0, path.LastIndexOf("\\")) + "\\" + name + "\\";

            var size = 1024 * 1024 * int.Parse(SplitSize.Text == "" ? "128" : SplitSize.Text);
            var count = fs.Length / size;

            for (var i = 0; i <= count; i++)
            {
                byte[] buffer = br.ReadBytes(size);

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                StreamWriter sw = new StreamWriter(path + DateTime.UtcNow.Ticks + ".txt");
                sw.Write(Encoding.Default.GetString(buffer, 0, buffer.Length));
                sw.Close();
            }

            br.Close();
            fs.Close();

            MessageBox.Show("分割完毕!");
        }

        private void SetText(string text)
        {
            if (TextData.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                TextData.AppendText(text);
                TextData.Refresh();
            }
        }

        private void AddText()
        {
            if (allDatas[0].Count > 0)
            {
                TextData.Clear();
                TextData.Refresh();

                Thread th = new Thread(() =>
                {
                    string t = "";
                    for (int i = page * 1000; i < (page + 1) * 1000; i++)
                    {
                        if (allDatas[part].Count < i + 1)
                            break;
                        t += allDatas[part][i] + "\n";
                    }
                    SetText(t);
                });

                th.Start();
            }

            Parts.Text = string.Format("{0}/{1} 份", part + 1, allDatas.Count);
            Pages.Text = string.Format("{0}/{1} 页", page + 1, (allDatas[part].Count / 1000) + 1);
        }

        private void AddSearchText()
        {
            if (searchDatas.Count > 0)
            {
                TextData.Clear();
                TextData.Refresh();

                Thread th = new Thread(() =>
                {
                    string t = "";
                    for (int i = spage * 1000; i < (spage + 1) * 1000; i++)
                    {
                        if (searchDatas.Count < i + 1)
                            break;
                        t += searchDatas[spart][i] + "\n";
                    }
                    SetText(t);
                });

                th.Start();
            }

            Parts.Text = string.Format("{0}/{1} 份", spart + 1, searchDatas.Count);
            Pages.Text = string.Format("{0}/{1} 页", spage + 1, (searchDatas[spart].Count / 1000) + 1);
        }

        private void LastPage_Click(object sender, EventArgs e)
        {
            if (searchDatas.Count > 0)
            {
                if (spage > 0)
                {
                    spage--;
                    AddSearchText();
                }
            }
            else
            {
                if (page > 0)
                {
                    page--;
                    AddText();
                }
            }
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            if (searchDatas.Count > 0)
            {
                if (spage < searchDatas[spart].Count / 1000)
                {
                    spage++;
                    AddSearchText();
                }
            }
            else
            {
                if (page < allDatas[part].Count / 1000)
                {
                    page++;
                    AddText();
                }
            }
        }

        private void Page_TextChanged(object sender, EventArgs e)
        {
            if (Page.Text != "")
            {
                if (int.TryParse(Page.Text, out int r))
                {
                    if (r <= 0) return;
                    if (searchDatas.Count > 0)
                    {
                        spage = r - 1;
                        AddSearchText();
                    }
                    else
                    {
                        page = r - 1;
                        AddText();
                    }
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            searchDatas = new Dictionary<int, List<string>>();

            if (SearchValue.Text == "")
            {
                AddText();
            }
            else
            {
                int i = 0;
                foreach (var data in allDatas)
                {
                    var a = data.Value.FindAll(d => d.Contains(SearchValue.Text));
                    if (a.Count > 0)
                    {
                        foreach (var s in a)
                        {
                            if (!searchDatas.ContainsKey(i))
                                searchDatas[i] = new List<string>();
                            if (searchDatas[i].Count + 1 > int.MaxValue)
                                searchDatas[++i] = new List<string>();
                            searchDatas[i].Add(s);
                        }
                    }
                }

                if (searchDatas.Count == 0)
                {
                    MessageBox.Show("无相关内容!");
                    SearchValue.Text = "";
                }
                else
                {
                    spart = 0;
                    spage = 0;
                    AddSearchText();
                }
            }
        }

        private void LastPart_Click(object sender, EventArgs e)
        {
            if (searchDatas.Count > 0)
            {
                if (spart > 0)
                {
                    spart--;
                    spage = 0;
                    AddSearchText();
                }
            }
            else
            {
                if (part > 0)
                {
                    part--;
                    page = 0;
                    AddText();
                }
            }
        }

        private void NextPart_Click(object sender, EventArgs e)
        {
            if (searchDatas.Count > 0)
            {
                if (spart + 1 < searchDatas.Count)
                {
                    spart++;
                    spage = 0;
                    AddSearchText();
                }
            }
            else
            {
                if (part + 1 < allDatas.Count)
                {
                    part++;
                    page = 0;
                    AddText();
                }
            }
        }

        private void _Part_TextChanged(object sender, EventArgs e)
        {
            if (_Part.Text != "")
            {
                if (int.TryParse(_Part.Text, out int r))
                {
                    if (r <= 0) return;
                    if (searchDatas.Count > 0)
                    {
                        spart = r - 1;
                        spage = 0;
                        AddSearchText();
                    }
                    else
                    {
                        part = r - 1;
                        page = 0;
                        AddText();
                    }
                }
            }
        }
    }
}
