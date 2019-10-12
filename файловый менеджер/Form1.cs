using System;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace файловый_менеджер
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            GetDrive();
            Drivers1_SetText();
            Drivers2_SetText();
            way1.Text = "C:\\";
            way2.Text = "C:\\";
        }
        internal ImageList ImageList1;
        private void GetDrive()
        {
            InitializeComponent();
            DriveInfo[] drivers = DriveInfo.GetDrives();
            string[] str = new string[drivers.Length];
            int i = 0;
            foreach (DriveInfo driv in drivers)
            {                
                str[i] = driv.ToString();              
                i++;
            }
            Drivers2.Items.AddRange(str);
            Drivers1.Items.AddRange(str);
            string[] str2 = { "По размеру", "По дате"};
            comboBox1.Text = "Сортировка";
            comboBox2.Text = "Сортировка";
            comboBox1.Items.AddRange(str2);
            comboBox2.Items.AddRange(str2);
        }       
        
        public void Drivers1_SetText()
        {
            if (Drivers1.Text.Length == 0)
            {
                this.Drivers1.Text = "choose in window 1";
                DirectoryInfo dir = new DirectoryInfo("C:\\");
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo m in dirs)
                {
                    List1.Items.Add(m);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo m in files)
                {
                    List1.Items.Add(m);
                }
            }
        }

        public void Drivers2_SetText()
        {
            if (Drivers2.Text.Length == 0)
            {
                this.Drivers2.Text = "choose dir window 2";
                DirectoryInfo dir = new DirectoryInfo("C:\\");
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo m in dirs)
                {
                    List2.Items.Add(m);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo m in files)
                {
                    List2.Items.Add(m);
                }
            }
        }

        int i;
        bool flag;
        string way,done,file;
        FileInfo[] mas;
        bool size1, size2, date1, date2;
        List<string> hronic1 = new List<string>() { "C:\\" }, hronic2 = new List<string>() { "C:\\" };
        int count1=0, count2=0;
        private void delete1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string way = Path.Combine(way1.Text, List1.SelectedItem.ToString());
                if (Path.GetExtension(Path.Combine(way1.Text, List1.SelectedItem.ToString())) != "")
                    File.Delete(way);
                if (Path.GetExtension(Path.Combine(way1.Text, List1.SelectedItem.ToString())) == "")
                    Directory.Delete(way, true);
                List1.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(way1.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo m in dirs)
                {
                    List1.Items.Add(m);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo m in files)
                {
                    List1.Items.Add(m);
                }
            }
            catch(Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
        }


        private void delete2_Click(object sender, EventArgs e)
        {
            try
            {
                string way = Path.Combine(way2.Text, List2.SelectedItem.ToString());
                if (Path.GetExtension(Path.Combine(way2.Text, List2.SelectedItem.ToString())) != "")
                    File.Delete(way);
                if (Path.GetExtension(Path.Combine(way2.Text, List2.SelectedItem.ToString())) == "")
                    Directory.Delete(way, true);
                List2.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(way2.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo m in dirs)
                {
                    List2.Items.Add(m);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo m in files)
                {
                    List2.Items.Add(m);
                }
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
        }
        private void copy1_Click(object sender, EventArgs e)
        {
            try
            {                
                done = Path.Combine(way1.Text, List1.SelectedItem.ToString());
                if (Path.GetExtension(done) == "")
                {
                    DirectoryInfo dir = new DirectoryInfo(done);
                    mas = dir.GetFiles();
                    flag = true;
                }
                file = List1.SelectedItem.ToString();
                i = 1;
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
        }
        private void copy2_Click(object sender, EventArgs e)
        {
            try
            {
                done = Path.Combine(way2.Text, List2.SelectedItem.ToString());
                if (Path.GetExtension(done) == "")
                {
                    DirectoryInfo dir = new DirectoryInfo(done);
                    mas = dir.GetFiles();
                    flag = true;
                }
                file = List2.SelectedItem.ToString();
                i = 1;
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
        }
        private void move1_Click(object sender, EventArgs e)
        {
            try
            {
                done = Path.Combine(way1.Text, List1.SelectedItem.ToString());
                file = List1.SelectedItem.ToString();
                i = 2;
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
        }
        private void move2_Click(object sender, EventArgs e)
        {
            try
            {
                done = Path.Combine(way2.Text, List2.SelectedItem.ToString());
                file = List2.SelectedItem.ToString();
                i = 2;
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
        }
        private void insert1_Click(object sender, EventArgs e)
        {
            try
            {
                way = Path.Combine(way1.Text, file);
                if (i == 1)
                {
                    if(flag)
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(way);
                        if (!dirInfo.Exists)
                        {
                            dirInfo.Create();
                        }
                        foreach(FileInfo m in mas)
                        {
                            string newPath=Path.Combine(way,m.Name);
                            m.CopyTo(newPath, true);
                        }
                    }
                    else
                    File.Copy(done, way, false);
                }
                if (i == 2)
                {
                    File.Move(done, way);
                    List2.Items.Clear();
                    DirectoryInfo direct = new DirectoryInfo(way2.Text);
                    DirectoryInfo[] dires = direct.GetDirectories();
                    foreach (DirectoryInfo m in dires)
                    {
                        List2.Items.Add(m);
                    }
                    FileInfo[] fils = direct.GetFiles();
                    foreach (FileInfo m in fils)
                    {
                        List2.Items.Add(m);
                    }
                }
                List1.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(way1.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo m in dirs)
                {
                    List1.Items.Add(m);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo m in files)
                {
                    List1.Items.Add(m);
                }
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
        }
        private void insert2_Click(object sender, EventArgs e)
        {
            try
            {
                way = Path.Combine(way2.Text, file);
                if (i == 1)
                {                    
                    if (flag)
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(way);
                        if (!dirInfo.Exists)
                        {
                            dirInfo.Create();
                        }
                        foreach (FileInfo m in mas)
                        {
                            string newPath = Path.Combine(way, m.Name);
                            m.CopyTo(newPath, true);
                        }
                    }
                    else
                        File.Copy(done, way, false);
                }
                if (i == 2)
                {
                    File.Move(done, way);
                    List1.Items.Clear();
                    DirectoryInfo direct = new DirectoryInfo(way1.Text);
                    DirectoryInfo[] dires = direct.GetDirectories();
                    foreach (DirectoryInfo m in dires)
                    {
                        List1.Items.Add(m);
                    }
                    FileInfo[] fils = direct.GetFiles();
                    foreach (FileInfo m in fils)
                    {
                        List1.Items.Add(m);
                    }
                }
                List2.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(way2.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo m in dirs)
                {
                    List2.Items.Add(m);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo m in files)
                {
                    List2.Items.Add(m);
                }
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
        }
        


        //
        private void Drivers2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedState = Drivers2.SelectedItem.ToString();
                way2.Text = selectedState;
                hronic2.Add(selectedState);
                count2++;
                List2.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(selectedState);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo m in dirs)
                {
                    List2.Items.Add(m);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo m in files)
                {
                    List2.Items.Add(m);
                }
            }
            catch (Exception name)
            {
                MessageBox.Show(name.Message);
            }
        }
        //
        private void Drivers1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedState = Drivers1.SelectedItem.ToString();
                way1.Text = selectedState;
                hronic1.Add(selectedState);
                count1++;
                List1.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(selectedState);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo m in dirs)
                {
                    List1.Items.Add(m);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo m in files)
                {
                    List1.Items.Add(m);
                }
            }
            catch(Exception name)
            {
                MessageBox.Show(name.Message);
            }
        }
        //  
        private void List1_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            if (Path.GetExtension(Path.Combine(way1.Text, List1.SelectedItem.ToString())) == "")
            {
                way = Path.Combine(way1.Text, List1.SelectedItem.ToString());
                way1.Text = Path.Combine(way1.Text, List1.SelectedItem.ToString());                
                count1++;
                if (count1 < hronic1.Count)
                {
                    if (hronic1[count1] != way1.Text)
                    {
                        int size = hronic1.Count - count1;
                        hronic1.RemoveRange(count1, size);
                        hronic1.Add(way1.Text);
                    }
                }
                hronic1.Add(way1.Text);
                List1.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(way1.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo m in dirs)
                {
                    List1.Items.Add(m);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo m in files)
                {
                    List1.Items.Add(m);
                }                
            }
            else
            {
                Process.Start(Path.Combine(way1.Text, List1.SelectedItem.ToString()));
            }
        }
        private void way1_TextChanged(object sender, EventArgs e)
        {
            
        }
        //
        private void back1_Click(object sender, EventArgs e)
        {
            if (!(way1.Text.Length == 3))
            {
                if (way1.Text[way1.Text.Length - 1] == '\\')
                {
                    
                    count1--;
                    way1.Text = hronic1[count1];
                }
                else if (way1.Text[way1.Text.Length - 1] != '\\')
                {
                    
                    count1--;
                    way1.Text = hronic1[count1];
                }
                List1.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(way1.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo m in dirs)
                {
                    List1.Items.Add(m);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo m in files)
                {
                    List1.Items.Add(m);
                }
            }
        }
        


        //
        private void List2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Path.GetExtension(Path.Combine(way2.Text, List2.SelectedItem.ToString())) == "")
            {
                way2.Text = Path.Combine(way2.Text, List2.SelectedItem.ToString());                
                count2++;
                if (count2 < hronic2.Count)
                {
                    if (hronic2[count2] != way2.Text)
                    {
                        int size = hronic2.Count - count2;
                        hronic2.RemoveRange(count2, size);
                        hronic2.Add(way2.Text);
                    }
                }
                hronic2.Add(way2.Text);
                List2.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(way2.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo m in dirs)
                {
                    List2.Items.Add(m);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo m in files)
                {
                    List2.Items.Add(m);
                }
            }
            else
            {
                Process.Start(Path.Combine(way2.Text, List2.SelectedItem.ToString()));
            }

        }
       //
        private void back2_Click(object sender, EventArgs e)
        {
            if (!(way2.Text.Length == 3))
            {
                if (way2.Text[way2.Text.Length - 1] == '\\')
                {
                    count2--;
                    way2.Text = hronic2[count2];
                }
                else if (way2.Text[way2.Text.Length - 1] != '\\')
                {                   
                    count2--;
                    way2.Text = hronic2[count2];
                }
                List2.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(way2.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo m in dirs)
                {
                    List2.Items.Add(m);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo m in files)
                {
                    List2.Items.Add(m);
                }
            }
        }
        private void way2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedState = comboBox2.SelectedItem.ToString();
                Poisk2.Text = selectedState;             
                
            }
            catch (Exception name)
            {
                MessageBox.Show(name.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedState = comboBox1.SelectedItem.ToString();
                Poisk1.Text = selectedState;

            }
            catch (Exception name)
            {
                MessageBox.Show(name.Message);
            }
        }

        private void search1_Click(object sender, EventArgs e)
        {            
            try
            {
                
                List1.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(way1.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                if (comboBox1.Text== "По дате")
                {
                    if (date1)
                    {
                        FileInfo temp;
                        for (int i = 0; i < files.Length - 1; i++)
                        {
                            for (int j = files.Length - 1; j > i; j--)
                            {
                                if (files[i].CreationTime < files[j].CreationTime)
                                {
                                    temp = files[i];
                                    files[i] = files[j];
                                    files[j] = temp;
                                }
                            }
                            
                        }
                        DirectoryInfo dirinfo;
                        for (int i = 0; i < dirs.Length - 1; i++)
                        {
                            for (int j = dirs.Length - 1; j > i; j--)
                            {
                                if (dirs[i].CreationTime < dirs[j].CreationTime)
                                {
                                    dirinfo = dirs[i];
                                    dirs[i] = dirs[j];
                                    dirs[j] = dirinfo;
                                }
                            }
                            
                        }
                        date1 = false;
                    }
                    else
                    {
                        dirs = dirs.OrderBy(x => x.CreationTime).ToArray();
                        files = files.OrderBy(x => x.CreationTime).ToArray();
                        date1 = true;
                    }
                }
                else
                {
                    if (size1)
                    {
                        FileInfo temp;
                        for (int i = 0; i < files.Length - 1; i++)
                        {
                            for (int j = files.Length - 1; j > i; j--)
                            {
                                if (files[i].Length < files[j].Length)
                                {
                                    temp = files[i];
                                    files[i] = files[j];
                                    files[j] = temp;
                                }
                            }
                            size1 = false;
                        }
                    }
                    else
                    {
                        files = files.OrderBy(x => x.Length).ToArray();
                        size1=true;
                    }
                }      
                

                foreach (DirectoryInfo m in dirs)
                {
                    List1.Items.Add(m);
                }            
                
                foreach (FileInfo m in files)
                {
                    List1.Items.Add(m);
                }
                
            }
            catch(Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
        }

        private void search2_Click(object sender, EventArgs e)
        {
            try
            {

                List2.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(way2.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                if (comboBox2.Text == "По дате")
                {
                    if (date2)
                    {
                        FileInfo temp;
                        for (int i = 0; i < files.Length - 1; i++)
                        {
                            for (int j = files.Length - 1; j > i; j--)
                            {
                                if (files[i].CreationTime < files[j].CreationTime)
                                {
                                    temp = files[i];
                                    files[i] = files[j];
                                    files[j] = temp;
                                }
                            }

                        }
                        DirectoryInfo dirinfo;
                        for (int i = 0; i < dirs.Length - 1; i++)
                        {
                            for (int j = dirs.Length - 1; j > i; j--)
                            {
                                if (dirs[i].CreationTime < dirs[j].CreationTime)
                                {
                                    dirinfo = dirs[i];
                                    dirs[i] = dirs[j];
                                    dirs[j] = dirinfo;
                                }
                            }

                        }
                        date2 = false;
                    }
                    else
                    {
                        dirs = dirs.OrderBy(x => x.CreationTime).ToArray();
                        files = files.OrderBy(x => x.CreationTime).ToArray();
                        date2 = true;
                    }
                }                
                else
                {
                    if (size2)
                    {
                        FileInfo temp;
                        for (int i = 0; i < files.Length - 1; i++)
                        {
                            for (int j = files.Length - 1; j > i; j--)
                            {
                                if (files[i].Length < files[j].Length)
                                {
                                    temp = files[i];
                                    files[i] = files[j];
                                    files[j] = temp;
                                }
                            }
                            size2 = false;
                        }
                    }
                    else
                    {
                        files = files.OrderBy(x => x.Length).ToArray();
                        size2 = true;
                    }
                }


                foreach (DirectoryInfo m in dirs)
                {
                    List2.Items.Add(m);
                }

                foreach (FileInfo m in files)
                {
                    List2.Items.Add(m);
                }
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
        }
        //
        private void forward1_Click(object sender, EventArgs e)
        {
            count1++;
            if(count1<=hronic1.Count)
            {
                way1.Text = hronic1[count1];
                List1.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(way1.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo m in dirs)
                {
                    List1.Items.Add(m);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo m in files)
                {
                    List1.Items.Add(m);
                }
            }
        }
        //
        private void forward2_Click(object sender, EventArgs e)
        {
            count2++;
            if (count2 <= hronic2.Count)
            {
                way2.Text = hronic2[count2];
                List2.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(way2.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo m in dirs)
                {
                    List2.Items.Add(m);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo m in files)
                {
                    List2.Items.Add(m);
                }
            }
        }

        private void Compress1_Click(object sender, EventArgs e)
        {
            string sourcefile= Path.Combine(way1.Text, List1.SelectedItem.ToString()); ;
            string fail = Path.Combine(way1.Text,List1.SelectedItem.ToString());
            if (fail[fail.Length - 1] != '.')
            {
                while (fail[fail.Length - 1] != '.')
                {
                    fail = fail.Remove(fail.Length - 1, 1);
                }
            }
            fail += "gz";
            MessageBox.Show(fail);
            Compress(sourcefile,fail);
            List1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(way1.Text);
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo m in dirs)
            {
                List1.Items.Add(m);
            }
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo m in files)
            {
                List1.Items.Add(m);
            }
        }

        private void Compress2_Click(object sender, EventArgs e)
        {
            string sourcefile = Path.Combine(way2.Text, List2.SelectedItem.ToString()); ;
            string fail = Path.Combine(way2.Text, List2.SelectedItem.ToString());
            if (fail[fail.Length - 1] != '.')
            {
                while (fail[fail.Length - 1] != '.')
                {
                    fail = fail.Remove(fail.Length - 1, 1);
                }
            }
            fail += "gz";
            MessageBox.Show(fail);
            Compress(sourcefile, fail);
            List2.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(way2.Text);
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo m in dirs)
            {
                List2.Items.Add(m);
            }
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo m in files)
            {
                List2.Items.Add(m);
            }
        }
        public static void Compress(string sourceFile, string compressedFile)
        {            
            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate))
            {                
                using (FileStream targetStream = File.Create(compressedFile))
                {                    
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream); 
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Poisk1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Poisk2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {                      
            if (e.KeyValue == (char)Keys.F4)
            {
                if(Path.GetExtension(Path.Combine(way2.Text, List2.SelectedItem.ToString())) == ".txt"){
                    Process.Start(Path.Combine(way2.Text, List2.SelectedItem.ToString()));

                }
                else if (Path.GetExtension(Path.Combine(way1.Text, List1.SelectedItem.ToString())) == ".txt")
                {
                    Process.Start(Path.Combine(way1.Text, List1.SelectedItem.ToString()));

                }

            }
        }

    }
}
