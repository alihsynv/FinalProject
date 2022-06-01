using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "The product name is invalid.";
        public static string MaintenanceTime = "Maintenance time";
        public static string ProductsListed = "Products listed";
        public static string ProductCountOfCategoryError = "A category can have a maximum of 10 products";
        public static string ProductUpdated = "Product updated";
        public static string ProductNameAlreadyExists = "There is already another product with this name";
        public static string CategoryLimitExceded = "New products cannot be added because the category limit has been exceeded";
        public static string AuthorizationDenied = "You are not authorized";
        public static string UserRegistered = "Registered";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password error";
        public static string SuccessfulLogin = "Successful login";
        public static string UserAlreadyExists = "User already exists";
        public static string AccessTokenCreated = "Access token created";
    }
}
