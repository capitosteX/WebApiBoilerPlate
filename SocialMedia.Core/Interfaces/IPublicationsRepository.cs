using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
    public interface IPublicationsRepository
    {
        Task<IEnumerable<Publicacion>> GetPublicacions();
    }
}
