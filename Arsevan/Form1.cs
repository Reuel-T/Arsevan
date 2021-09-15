using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Arsevan
{
    public partial class Form1 : Form
    {
        Stack<Movie> movieStack = new Stack<Movie>();
        string FileText = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            movieStack.Push(new Movie(txtTitle.Text));
            lstMovies.Items.Add(txtTitle.Text);
        }

        private void populateStack() 
        {
            movieStack.Push(new Movie("Coco"));
            lstMovies.Items.Add("Coco");
            movieStack.Push(new Movie("Mulan"));
            lstMovies.Items.Add("Mulan");
            movieStack.Push(new Movie("Tangled"));
            lstMovies.Items.Add("Tangled");
            movieStack.Push(new Movie("Rio"));
            lstMovies.Items.Add("Rio");
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            populateStack();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Removed {movieStack.Pop().Title}");
            lstMovies.Items.RemoveAt(lstMovies.Items.Count - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Next Movie is {movieStack.Peek().Title}");
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            fdFile.ShowDialog();
            
            FileText = File.ReadAllText(fdFile.FileName);

            rtbFile.Text = FileText;
        }

        private void btnCheckBrackets_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Balance().ToString());
        }

        private bool Balance() 
        {
            int i = 0;
            rtbOutput.Text = String.Empty;

            Stack<char> stack = new Stack<char>();

            //check if there are parenthesis to balance
            if (FileText.Contains('{') || FileText.Contains('(') || FileText.Contains('[') || FileText.Contains(']') || FileText.Contains(')') || FileText.Contains('}')) 
            {
                //check each character
                foreach (char c in FileText)
                {
                    //push opening brackets to stack
                    switch (c)
                    {
                        case '{': stack.Push(c); rtbOutput.AppendText($"\n Pushed {c} to stack"); break;
                        case '(': stack.Push(c); rtbOutput.AppendText($"\n Pushed {c} to stack"); break;
                        case '[': stack.Push(c); rtbOutput.AppendText($"\n Pushed {c} to stack"); break;

                        default:
                            break;
                    }

                    //when we encounter a closed bracket, pop off from the stack and check if it is a matching bracket
                    switch (c)
                    {
                        case '}':
                            if (stack.IsEmpty()) 
                            {
                                rtbOutput.AppendText($"{c} - Stack Empty - Early cancel");
                                return false;
                            }
                            else 
                            {
                                if(stack.Pop() != '{') 
                                {
                                    rtbOutput.AppendText($"\n{c} - No match - cb  i = {i}");
                                    rtbOutput.AppendText($"\n Bad chars - {FileText.Substring(i, 50)}  /{c}/");
                                    return false;
                                }
                                else 
                                {
                                    rtbOutput.AppendText($"\n Pop Successful {c} ");
                                }
                                break;
                            }
                        
                        case ')':
                            if (stack.IsEmpty()) 
                            {
                                rtbOutput.AppendText($"{c} - Stack Empty - Early cancel");
                                return false;
                            }
                            else 
                            {
                                if(stack.Pop() != '(') 
                                {
                                    rtbOutput.AppendText($"\n{c} - No match - b i = {i}");
                                    rtbOutput.AppendText($"\n Bad chars - {FileText.Substring(i, 50)}  /{c}/");
                                    return false;
                                }
                                else 
                                {
                                    rtbOutput.AppendText($"\n Pop Successful {c} ");
                                }
                                break;
                            }
                        
                        case ']':
                            if (stack.IsEmpty()) 
                            {
                                rtbOutput.AppendText($"{c} - Stack Empty - Early cancel");
                                return false;
                            }
                            else 
                            {
                                if(stack.Pop() != '[') 
                                {
                                    rtbOutput.AppendText($"\n{c} - No match - sb i = {i}");
                                    rtbOutput.AppendText($"\n Bad chars - {FileText.Substring(i, 50)}  /{c}/");
                                    return false;
                                }
                                else 
                                {
                                    rtbOutput.AppendText($"\n Pop Successful {c} ");
                                }
                                break;
                            }

                        default:
                            break;
                    }
                    i++;
                }
                
                bool result = stack.IsEmpty();

                if (!result) 
                {
                    rtbOutput.AppendText("\nStack was not empty");
                }

                return result;

            }
            else 
            {
                //no parenthesis to balance
                return false;
            }            
        }

        private void btnConvertNumber_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumber.Text.Trim());
            txtBinary.Text = Regex.Replace(convToBinary(number), ".{4}", "$0 "); ;
        }

        private string convToBinary(int num) 
        {
            Stack<int> binDigits = new Stack<int>();
            do
            {
                binDigits.Push(num % 2);
                num /= 2;
            } while (num != 0);

            StringBuilder sb = new StringBuilder();

            while (binDigits.Size > 0)
            {
                sb.Append(binDigits.Pop());
            }

            return sb.ToString();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            Stack<char> stack = new Stack<char>();
            string phrase = txtString.Text;

            //L A * S T I * N * F I R * S T * * O U * T * * * * * *

            foreach (char c in phrase)
            {
                if (c != '*')
                {
                    stack.Push(c);
                }
                else 
                {
                    stack.Pop();
                }
            }

            //L - wow

        }
    }
}

