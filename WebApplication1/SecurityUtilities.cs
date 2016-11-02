//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using WebApplication1.App_Start;

//namespace WebApplication1
//{
//    public class SecurityUtilities
//    {
//        #region variables
//        private const string SessionName = "user";
//        #endregion

//        /*******************************************************************
//         * Function: Checks if a user inserted correct username and password
//         *           then saves it into a session object.
//         * Call: SecurityUtilities.AthenticateUser(user)
//         *******************************************************************/
//        public static bool AuthenticateUser(User u, Controller con)
//        {
//            if (String.IsNullOrEmpty(u.Username) || String.IsNullOrEmpty(u.Password))
//            {
//                return false;
//            }

//            var crypto = new SimpleCrypto.PBKDF2();
//            User nUser = User.CheckUser(u);
//            if ((nUser != null) && (nUser.Password == crypto.Compute(u.Password, nUser.PasswordSalt)))
//            {
//                CreateSession(nUser, con);
//                return true;
//            }

//            return false;
//        }

//        /******************************************************************
//         * Function: Determins whether the connecting client is logged in.
//         * Call: SecurityUtilities.Authenticated()
//         ************************************************************************************************/
//        public static bool Authenticated(Controller con)
//        {
//            return con.Session[SessionName] != null;
//        }

//        /******************************************************************
//         * Function: Determins whether the connecting client is logged in.
//         * Call: SecurityUtilities.Authenticated()
//         ************************************************************************************************/
//        public static bool Authenticated()
//        {
//            return HttpContext.Current.Session[SessionName] != null;
//        }

//        /************************************************************************************************
//         * Function: Determins whether the logged in client has permission
//         * to access material belonging to the specified teacherId.
//         * Call: SecurityUtilities.AuthorizedAsTeacher(teacherID of the content that is beeing requested)
//         ************************************************************************************************/
//        public static bool AuthorizedAsTeacher(int teacherId, Controller con)
//        {
//            var user = con.Session[SessionName] as Repository.User;
//            return user.TeacherId == teacherId;
//        }

//        /***********************************************************************
//         * Function: Determins whether the logged in client has admin permission
//         * Call: SecurityUtilities.AuthorizedAsAdmin()
//         ***********************************************************************/
//        public static bool AuthorizedAsAdmin(Controller con)
//        {
//            var user = con.Session[SessionName] as Repository.User;
//            return user.UserRole == 1;
//        }

//        /*****************************************************
//         * Function: Adds a session for the authenticated user
//         * Call: SecurityUtilities.CreateSession
//         ****************************************************/
//        public static void CreateSession(User u, Controller con)
//        {
//            if (con.Session != null)
//            {
//                // Session will be null when unit testing
//                con.Session[SessionName] = u;
//            }
//        }

//        /**************************************
//         * Function: Clears the current session
//         * Call: SecurityUtilities.ClearSession
//         *************************************/
//        public static void ClearSession(Controller con)
//        {
//            con.Session[SessionName] = null;
//        }
//        /**********************************************************
//         * Function: Returns a user with salted and hashed password
//         * Call: SecurityUtilities.HashAndSaltPassword(pass, user)
//        ***********************************************************/
//        public static User HashAndSaltPassword(string pass, User u)
//        {
//            User nUser = new User();
//            nUser = u;
//            var crypto = new SimpleCrypto.PBKDF2();
//            nUser.Password = crypto.Compute(pass);
//            nUser.PasswordSalt = crypto.Salt;
//            return nUser;
//        }

//        /***************************************************
//         * Function: Returns the user stored in the session
//         * Call: SecurityUtilities.GetSessionUser()
//        ****************************************************/
//        public static User GetSessionUser(Controller con)
//        {
//            return con.Session[SessionName] as Repository.User;
//        }

//        /***************************************************
//         * Function: Returns the user stored in the session
//         * Call: SecurityUtilities.GetSessionUser()
//        ****************************************************/
//        public static User GetSessionUser()
//        {
//            return HttpContext.Current.Session[SessionName] as Repository.User;
//        }

        
//    }
//}