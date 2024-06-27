using System;
using System.Collections.Generic;

namespace DietApp
{
    public class UserManager
    {
        private List<User> users = new List<User>();

        public void Register(string email, string password, string firstName, string lastName, DateTime birthDate, string gender, int height, int weight, int goalWeight)
        {
            User user = new User
            {
                Email = email,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                Gender = gender,
                Height = height,
                Weight = weight,
                GoalWeight = goalWeight
            };

            users.Add(user);
        }

        public User Login(string email, string password)
        {
            return users.Find(user => user.Email == email && user.Password == password);
        }
    }
}
