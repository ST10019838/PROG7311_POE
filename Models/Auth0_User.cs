namespace ST10019838_DamianDare_PROG7311_POE.Models
{
    public class Auth0_User
    {
        public string User_id { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }


        //Schema for User creation
        /*{
           "email": "user5232@example.com",
           "name": "string",
           "connection": "Username-Password-Authentication",
           "password": "Password123#",
           "username": "TestUser2"
        } */


        // Response body to use for user creation
        /*
            {
              "statusCode": 400,
              "error": "Bad Request",
              "message": "The username provided is in use already.",
              "errorCode": "auth0_idp_error"
            }
         */


        // Schema for user retrieval
        /* [
               {
                 "user_id": "auth0|1",
                 "email": "user@example.com",
                 "picture": "https://s.gravatar.com/avatar/b58996c504c5638798eb6b511e6f49af?s=480&r=pg&d=https%3A%2F%2Fcdn.auth0.com%2Favatars%2Fno.png",
                 "name": "no"
               },
               {
                 "user_id": "auth0|6658f3f98cbcd958e00f335b",
                 "email": "user2@example.com",
                 "picture": "https://s.gravatar.com/avatar/ab53a2911ddf9b4817ac01ddcd3d975f?s=480&r=pg&d=https%3A%2F%2Fcdn.auth0.com%2Favatars%2Fno.png",
                 "name": "no"
               } 
           ]
        */
    }
}
