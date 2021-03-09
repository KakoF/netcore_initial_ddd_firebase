using Api.Data.Context.Interface;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace Api.Data.Repositories
{
 public class FirebaseConnection : IFirebaseConnection
    {
        private IFirebaseConfig _config =  new FirebaseConfig{
           AuthSecret ="tUiIQ7tibpZ0IHBiqvDFBAmU6459sfP6HZc6VqMj",
            BasePath = "https://microservicecoreauth-default-rtdb.firebaseio.com/"
        };
        public FireSharp.FirebaseClient Init()
        {
            return new FireSharp.FirebaseClient(_config);
        }
    }
}