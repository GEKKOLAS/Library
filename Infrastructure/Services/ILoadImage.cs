using System;

namespace Infrastructure.Services;

public interface ILoadImage
{
    Task<string> SaveImage(Stream image, string name);

}
