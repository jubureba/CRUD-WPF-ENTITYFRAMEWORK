
using GRUDcomEntityFramework.EF;
using GRUDcomEntityFramework.HomePage;
using GRUDcomEntityFramework.Login_Page.code.Register;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace GRUDcomEntityFramework.Login_Page
{
    /// <summary>
    /// Lógica interna para LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        User user = new User();
        public LoginPage()
        {
            
            InitializeComponent();

            
        }

        private void closeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Close Application?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Close();
                }
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    

        private void minimizeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }catch(Exception ex)
            {
              
            }
            
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            try {
                user.Username = usernameregister.Text;
                user.Email = emailregister.Text;
                user.Password = txtPasswordRegister.Password;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                using (Context conn = new Context())
                {
                    conn.Users.Add(new Users()
                    {
                        Username = user.Username,
                        Email = user.Email,
                        Password = user.Password,
                        DateRegister = DateTime.Now
                    });
                    conn.SaveChanges();
                    MessageBox.Show("Successfully Registered", "All right",  MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparTxtRegister();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void LimparTxtRegister()
        {
            usernameregister.Text = "";
            emailregister.Text = "";
            txtPassword.Clear();
        }

        private void BtnSingupTop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void LoginButton(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Context conn = new Context())
                {
                    var user = conn.Users.FirstOrDefault(u => u.Username == txtLogin.Text);
                    if(user != null)
                    {
                        if (user.Password == txtPassword.Password)
                        {
                            MessageBox.Show("Login Successfully");
                            Index index = new Index();
                            index.Show();
                            this.Close();
                        }
                        else
                            MessageBox.Show("Wrong password");
                    }
                    else
                    {
                        MessageBox.Show("No user called " + txtLogin.Text + " Found");
                    }

                   /* foreach(var user in conn.Users)
                    {
                        if(user.Username == txtLogin.Text && user.Password == txtPassword.Password.ToString())
                        {
                            MessageBox.Show("LOGADO!");
                        }
                    }*/
                    //var LoginConfirmation = conn.Users.First(x => x.Username == txtLogin.Text && x.Password ==txtPassword.Password);
                    //MessageBox.Show(LoginConfirmation + LoginConfirmation.Password);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
