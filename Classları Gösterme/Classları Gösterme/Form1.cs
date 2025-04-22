using System.Reflection;

namespace Classları_Gösterme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDllSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "DLL veya EXE|*.dll;*.exe";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lstClasses.Items.Clear();
                string dosyaYolu = ofd.FileName;
                try
                {
                    Assembly asm = Assembly.LoadFrom(dosyaYolu);
                    Type[] types = asm.GetTypes();

                    var gruplar = types.GroupBy(t => t.Namespace);

                    foreach (var grup in gruplar)
                    {
                        lstClasses.Items.Add("📁 " + grup.Key);
                        foreach (Type t in grup)
                        {
                            if (t.IsClass)
                            {
                                lstClasses.Items.Add("   📄 " + t.Name);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Yüklenemedi: " + ex.Message);
                }
            }
        }
    }
}
