using Library_Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccess.SeedData.EntitySeedData
{
    public class AuthorPublisherSeedData : IEntityTypeConfiguration<AuthorPublisher>
    {
        public void Configure(EntityTypeBuilder<AuthorPublisher> builder)
        {
            builder.HasData
                (
                    new AuthorPublisher
                    {
                        PublisherId = 1,
                        AuthorId = 1
                    },
                    new AuthorPublisher
                    {
                        PublisherId = 2,
                        AuthorId = 2
                    },
                    new AuthorPublisher
                    {
                        PublisherId = 3,
                        AuthorId = 3
                    },
                    new AuthorPublisher
                    {
                        PublisherId = 4,
                        AuthorId = 4
                    },
                    new AuthorPublisher
                    {
                        PublisherId = 5,
                        AuthorId = 5
                    },
                    new AuthorPublisher
                    {
                        PublisherId = 6,
                        AuthorId = 6
                    },

                    new AuthorPublisher
                    {
                        PublisherId = 7,
                        AuthorId = 7
                    },
                    new AuthorPublisher
                    {
                        PublisherId = 8,
                        AuthorId = 8
                    },
                    new AuthorPublisher
                    {
                        PublisherId = 9,
                        AuthorId = 9
                    },
                    new AuthorPublisher
                    {
                        PublisherId = 10,
                        AuthorId = 10
                    },
                    new AuthorPublisher
                    {
                        PublisherId = 11,
                        AuthorId = 11
                    },
                    new AuthorPublisher
                    {
                        PublisherId = 12,
                        AuthorId = 12
                    }
                );
        }
    }
}
