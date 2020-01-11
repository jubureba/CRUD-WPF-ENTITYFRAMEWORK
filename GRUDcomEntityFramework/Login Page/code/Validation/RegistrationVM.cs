using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRUDcomEntityFramework.Login_Page.code
{
    public class RegistrationVM : ObservableObject
    {
        private string _username;
        private string _email;

        [Required(ErrorMessage = "Must not be empty.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Must be at least 5 characters.")]
     
        
        public string Username {
            get { return _username; }
            set {
                ValidateProperty(value, "Username");
                OnPropertyChanged(ref _username, value);
            }
        }
        public string Email {
            get { return _email; }
            set {
                ValidateProperty(value, "Email");
                OnPropertyChanged(ref _email, value);
            }
        }

        private void ValidateProperty<T>(T value, string name)
        {
            Validator.ValidateProperty(value, new ValidationContext(this, null, null)
            {
                MemberName = name
            });
        }
    }
}
