using System.Text;

namespace BogushevichKurs
{
    public partial class Form1 : Form
    {
        private const int MatrixSize = 2; // ����������� ������� ����� (��� ������� ����� 2�2)

        // ������� ����� ��� �������
        private readonly int[,] keyMatrix = { { 1, 2 }, { 3, 4 } }; // ������� ����� ��� �������

        private string EncryptHillCipher(string input, int[,] key)
        {
            // ��������, ��� ����� ������� ������ ������ ����������� �������
            if (input.Length % MatrixSize != 0)
                throw new ArgumentException("����� ������� ������ ������ ���� ������ ������� ������� �����.");

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i += MatrixSize)
            {
                // �������� ������ ������ ��� ���������� (������ = MatrixSize)
                string block = input.Substring(i, MatrixSize);

                // �������� ������� ����� �� ������-������� ���� (�� ������ 26)
                for (int row = 0; row < MatrixSize; row++)
                {
                    int sum = 0;
                    for (int col = 0; col < MatrixSize; col++)
                    {
                        sum += key[row, col] * (block[col] - 'a'); // 'a' = 0, 'b' = 1, ..., 'z' = 25
                    }
                    output.Append((char)((sum % 26) + 'a'));
                }
            }

            return output.ToString();
        }



        public Form1()
        {
            InitializeComponent();

            Auth auth_form = new Auth();
            auth_form.ShowDialog();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // �������� ��������� �����
                string inputText = Input.Text.ToLower(); // �������� � ������� ��������

                // ������� ����� � ������� ����� �����
                string encryptedText = EncryptHillCipher(inputText, keyMatrix);

                // ������� ������������� ����� � �����
                Output.Text = encryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("������: " + ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
