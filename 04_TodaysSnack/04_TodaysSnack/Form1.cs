namespace _04_TodaysSnack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("�g������z����͂��悤�I");
            }
            else
            {
                int pocket = Convert.ToInt32(textBox1.Text);
                string caption = "�ǂ��炩�I�ڂ��I";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result1;
                DialogResult result2;

                string message1 = "�Â��̂ɂ���H";
                string message2 = "�J�����[�͋C�ɂȂ�H";

                if(pocket < 300)
                {
                    label2.Text = "�J���J���V���[�N���[��������I";
                } else
                {
                    result1 = MessageBox.Show(message1, caption, buttons);
                    result2 = MessageBox.Show(message2, caption, buttons);

                    if (result1 == DialogResult.Yes & result2 == DialogResult.Yes)
                    {
                        label2.Text = "�Ղ�Ղ�R�[�q�[�[���[�ɂ��悤�I";
                    }
                    else if(result1== DialogResult.Yes & result2 == DialogResult.No) 
                    {
                        label2.Text = "�Z���L���������`�[�Y�^���g�ɂ��܂��傤�I";
                    }else if(result1== DialogResult.No &result2 == DialogResult.Yes)
                    {
                        label2.Text = "�v���e�B���[���[���ˁI";
                    }
                    else
                    {
                        label2.Text = "�r�^�[�J�J�I�G�N���A�ɂ��܂��傤�I";
                    }
                }
            }
        }
    }
}
