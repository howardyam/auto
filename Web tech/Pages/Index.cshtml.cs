﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Web_tech.Pages
{
    public class study_loginModel : PageModel
    {
        [BindProperty]
        public string? Username { get; set; }

        [BindProperty]
        public string? Password { get; set; }

        public string? Message { get; set; }

        public void OnGet()
        {
            // This method is executed when the page is loaded
        }

        public void OnPost()
        {
            // This method is executed when the login button is clicked

            string connectionString = "data source=GJohnsonPC\\MYMSSQLSERVER;initial catalog=WebTechAssignmentDB;trusted_connection=true;";
            string queryString = "SELECT * FROM Users WHERE UserName=@UserName AND UserPassword=@UserPassword";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);

            {
                command.Parameters.AddWithValue("@UserName", Username);
                command.Parameters.AddWithValue("@UserPassword", Password);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Message = "Login successful";
                }
                else
                {
                    Message = "Invalid username or password";
                }
            }
        }

    }
}