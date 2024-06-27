using System;
using System.Collections.Generic;

namespace DietApp
{
    public class UserManager
    {
        private List<User> users;

        public UserManager()
        {
            users = new List<User>();
        }

        public void Register(string email, string password, string firstName, string lastName, int age, string gender, float height)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("メールアドレスとパスワードは必須です。");
            }

            if (users.Exists(user => user.Email == email))
            {
                throw new ArgumentException("このメールアドレスは既に登録されています。");
            }

            User newUser = new User
            {
                Email = email,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Gender = gender,
                Height = height
            };

            users.Add(newUser);
        }

        public User Login(string email, string password)
        {
            User user = users.Find(u => u.Email == email && u.Password == password);
            if (user == null)
            {
                throw new ArgumentException("メールアドレスまたはパスワードが間違っています。");
            }

            return user;
        }
    }
}
