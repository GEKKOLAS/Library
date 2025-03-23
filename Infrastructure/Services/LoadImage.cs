using System;
using Firebase.Auth;
using Firebase.Storage;

namespace Infrastructure.Services;

public class LoadImage : ILoadImage
{
    public async Task<string> SaveImage(Stream image, string name)
    {
        string email = "nicolas.murillo@usantoto.edu.co";
        string password = "123456";
        string root = "librarydemo.appspot.com";
        string api_key = "AIzaSyD-1uJdZ9JrMgjJy6z1v6J9QJZ9Y1v9Y1";

        var auth = new FirebaseAuthProvider(new FirebaseConfig(api_key));
        var a = await auth.SignInWithEmailAndPasswordAsync(email, password);

        var cancelationToken = new CancellationTokenSource();

        var task = new FirebaseStorage(
            root,
            new FirebaseStorageOptions
            {
                AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                ThrowOnCancel = true
            })
            .Child("images")
            .Child(name)
            .PutAsync(image, cancelationToken.Token);

        var link = await task;
        return link;
    }
}
