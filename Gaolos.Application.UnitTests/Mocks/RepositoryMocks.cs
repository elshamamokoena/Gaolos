﻿using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using Moq;

namespace Gaolos.Application.UnitTests.Mocks
{
    public class RepositoryMocks
    {
        public static Mock<ICategoryRepository> GetCategoryRepository()
        {
            var indianCuisineGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
            var asianCuisineGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");
            var medicuisineGuid = Guid.Parse("{BF3F3002-7E53-441E-8B76-F6280BE284AA}");
            var afriCuisineGuid = Guid.Parse("{FE98F549-E790-4E9F-AA16-18C2292A2EE9}");

            var categories = new List<Category>
            {
                new Category
                {
                    CategoryId = indianCuisineGuid,
                    Name = "Indian cuisine"
                },
                new Category
                {
                    CategoryId = asianCuisineGuid,
                    Name = "Asian cuisine"
                },
                new Category
                {
                    CategoryId = afriCuisineGuid,
                    Name = "African cuisine"
                },
                 new Category
                {
                    CategoryId = medicuisineGuid,
                    Name = "Mediterranean"
                }
            };

            var mockCategoryRepository = new Mock<ICategoryRepository>();
            mockCategoryRepository.Setup(repo => repo.GetCategoriesAsync()).ReturnsAsync(categories);

            //mockCategoryRepository.Setup(repo => repo.AddCategory(It.IsAny<Category>())).ReturnsAsync(
            //    (Category category) =>
            //    {
            //        categories.Add(category);
            //        return category;
            //    });

            return mockCategoryRepository;
        }
    }
}
