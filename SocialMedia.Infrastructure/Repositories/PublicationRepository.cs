using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PublicationRepository : IPublicationsRepository
    {
        private readonly SocialMediaContext _context;
        public PublicationRepository(SocialMediaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Publicacion>> GetPublicacions()
        {
            var publications = await _context.Publicacion.ToListAsync();
            return publications;
        }
    }
}
