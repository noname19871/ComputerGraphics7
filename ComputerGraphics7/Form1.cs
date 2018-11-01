using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGraphics7
{
    public partial class Form1 : Form
    {
        private Graphics perspective_g;
        private Bitmap perspective_bmp;

        private Graphics orthographic_g;
        private Bitmap orthographic_bmp;

        private Primitive cur_primitive;


        private Transform get_perpective_transform()
        {
            switch (PerspectiveComboBox.SelectedItem.ToString())
            {
                case "Перспективная":
                    {
                        return Transform.PerspectiveProjection();
                    }
                case "Изометрическая":
                    {
                        return Transform.IsometricProjection();
                    }
                default:
                    {
                        return Transform.PerspectiveProjection();
                    }
            }
        }

        private Transform get_orthographic_transform()
        {
            switch (OrthographicComboBox.SelectedItem.ToString())
            {
                case "Ортографическая XY":
                    {
                        return Transform.OrthographicXYProjection();
                    }
                case "Ортографическая XZ":
                    {
                        return Transform.OrthographicXZProjection();
                    }
                case "Ортографическая YZ":
                    {
                        return Transform.OrthographicYZProjection();
                    }
                default:
                    {
                        return Transform.OrthographicXYProjection();
                    }
            }
        }

        //Рисует координатные оси 
        private void DrawAxis(Graphics g, Transform t, int width, int height)
        {
            List<Primitive> p = new List<Primitive>();
            XYZPoint a = new XYZPoint(0, 0, 0);
            XYZPoint b = new XYZPoint(0.8, 0, 0);
            XYZPoint c = new XYZPoint(0, 0.8, 0);
            XYZPoint d = new XYZPoint(0, 0, 0.8);

            p.Add(a);
            p.Add(b);
            p.Add(c);
            p.Add(d);

            p.Add(new XYZLine(a, b));
            p.Add(new XYZLine(a, c));
            p.Add(new XYZLine(a, d));

            p.Add(cur_primitive);

            foreach (Primitive x in p)
            {
                x.Draw(g, t, width, height);
            }
        }

        private void GetPrimitive()
        {
            switch (PrimitiveComboBox.SelectedItem.ToString())
            {
                case "Тетраэдр":
                    {
                        cur_primitive = new Tetrahedron(0.5);
                        break;
                    }
                case "Гексаэдр":
                    {
                        cur_primitive = new Hexahedron(0.5);
                        break;
                    }
                case "Октаэдр":
                    {
                        cur_primitive = new Octahedron(0.5);
                        break;
                    }
                case "Икосаэдр":
                    {
                        cur_primitive = new Icosahedron(0.5);
                        break;
                    }
                default:
                    {
                        cur_primitive = new Tetrahedron(0.5);
                        break;
                    }
            }
        }

        private void Clear()
        {
            perspective_bmp = new Bitmap(PerspectiveBox.Width, PerspectiveBox.Height);
            perspective_g = Graphics.FromImage(perspective_bmp);
            PerspectiveBox.Image = perspective_bmp;

            orthographic_bmp = new Bitmap(OrthographicBox.Width, OrthographicBox.Height);
            orthographic_g = Graphics.FromImage(orthographic_bmp);
            OrthographicBox.Image = orthographic_bmp;
        }

        public Form1()
        {
            InitializeComponent();

            //Создаем Bitmap и Graphics для двух PictureBox
            perspective_bmp = new Bitmap(PerspectiveBox.Width, PerspectiveBox.Height);
            perspective_g = Graphics.FromImage(perspective_bmp);
            PerspectiveBox.Image = perspective_bmp;

            orthographic_bmp = new Bitmap(OrthographicBox.Width, OrthographicBox.Height);
            orthographic_g = Graphics.FromImage(orthographic_bmp);
            OrthographicBox.Image = orthographic_bmp;

            //Инициализируем ComboBox для отображения проекций
            PerspectiveComboBox.SelectedItem = PerspectiveComboBox.Items[1];
            OrthographicComboBox.SelectedItem = OrthographicComboBox.Items[0];
            PrimitiveComboBox.SelectedItem = PrimitiveComboBox.Items[0];

            GetPrimitive();
            DrawAxis(perspective_g, get_perpective_transform(), PerspectiveBox.Width, PerspectiveBox.Height);
            DrawAxis(orthographic_g, get_orthographic_transform(), OrthographicBox.Width, OrthographicBox.Height);
        }

        private void ApplyPerspective_Click(object sender, EventArgs e)
        {
            perspective_bmp = new Bitmap(PerspectiveBox.Width, PerspectiveBox.Height);
            perspective_g = Graphics.FromImage(perspective_bmp);
            PerspectiveBox.Image = perspective_bmp;
            DrawAxis(perspective_g, get_perpective_transform(), PerspectiveBox.Width, PerspectiveBox.Height);
        }

        private void ApplyOrthographic_Click(object sender, EventArgs e)
        {
            orthographic_bmp = new Bitmap(OrthographicBox.Width, OrthographicBox.Height);
            orthographic_g = Graphics.FromImage(orthographic_bmp);
            OrthographicBox.Image = orthographic_bmp;
            DrawAxis(orthographic_g, get_orthographic_transform(), OrthographicBox.Width, OrthographicBox.Height);
        }

        private void ApplyPrimitive_Click(object sender, EventArgs e)
        {
            Clear();
            GetPrimitive();
            DrawAxis(perspective_g, get_perpective_transform(), PerspectiveBox.Width, PerspectiveBox.Height);
            DrawAxis(orthographic_g, get_orthographic_transform(), OrthographicBox.Width, OrthographicBox.Height);
        }

        //Смещение
        private void Translate()
        {
            double X = (double)numericUpDown1.Value;
            double Y = (double)numericUpDown2.Value;
            double Z = (double)numericUpDown3.Value;
            cur_primitive.Apply(Transform.Translate(X, Y, Z));
        }

        //Поворот
        private void Rotate()
        {
            double X = (double)numericUpDown4.Value / 180 * Math.PI;
            double Y = (double)numericUpDown5.Value / 180 * Math.PI;
            double Z = (double)numericUpDown6.Value / 180 * Math.PI;
            cur_primitive.Apply(Transform.RotateX(X) * Transform.RotateY(Y) * Transform.RotateZ(Z));
        }

        //Масштаб
        private void Scale()
        {
            double X = (double)numericUpDown7.Value;
            double Y = (double)numericUpDown8.Value;
            double Z = (double)numericUpDown9.Value;
            cur_primitive.Apply(Transform.Scale(X, Y, Z));

        }

        private void ApplyAffin_Click(object sender, EventArgs e)
        {
            Clear();
            Translate();
            Rotate();
            Scale();

            DrawAxis(perspective_g, get_perpective_transform(), PerspectiveBox.Width, PerspectiveBox.Height);
            DrawAxis(orthographic_g, get_orthographic_transform(), OrthographicBox.Width, OrthographicBox.Height);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Object Files(*.obj)| *.obj | Text files(*.txt) | *.txt | All files(*.*) | *.* ";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string info = "# Date: " + DateTime.Now.ToString() + "\r\n" + "\r\n";

                    int num = 1;
                    foreach (XYZPoint point in cur_primitive.Points)
                    {
                        info += "point #" + num;
                        info += "\r\n";
                        info += point.X + " ";
                        info += point.Y + " ";
                        info += point.Z;
                        info += "\r\n";
                        ++num;
                    }
                    info += "# " + cur_primitive.Points.Count + " vertices\r\n";
                    info += "\r\n";


                    num = 1;
                    foreach (Verge v in cur_primitive.Verges)
                    {
                        info += "verge #" + num;

                        info += "\r\n";
                        for (int i = 0; i < v.Points.Count; ++i)
                        {
                            info += v.Points[i].X + " " + v.Points[i].Y + " " + v.Points[i].Z;
                            info += "\r\n";
                        }
                        if(num != cur_primitive.Verges.Count)
                            info += "\r\n";
                        ++num;
                    }
                    info += "# " + cur_primitive.Verges.Count + " verges\r\n";

                    System.IO.File.WriteAllText(saveDialog.FileName, info);
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно сохранить файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
