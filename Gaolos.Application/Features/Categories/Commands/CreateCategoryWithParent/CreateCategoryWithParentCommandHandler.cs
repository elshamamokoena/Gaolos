using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Categories.Commands.CreateCategoryWithParent
{
    public class CreateCategoryWithParentCommandHandler: IRequestHandler<CreateCategoryWithParentCommand, CreateCategoryWithParentCommandResponse>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CreateCategoryWithParentCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CreateCategoryWithParentCommandResponse> Handle(CreateCategoryWithParentCommand request, CancellationToken cancellationToken)
        {
            var createCategoryResponse = new CreateCategoryWithParentCommandResponse();

            var validator = new CreateCategoryWithParentCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if(validationResult.Errors.Count > 0)
            {
                createCategoryResponse.Success = false;
                createCategoryResponse.ValidationErrors = new List<string>();
                foreach(var error in validationResult.Errors)
                {
                    createCategoryResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if(createCategoryResponse.Success)
            {
                var category = _mapper.Map<Category>(request);
                 _categoryRepository.AddCategory(category);
                await _categoryRepository.SaveAsync();
                createCategoryResponse.Category = _mapper.Map<CreateCategoryWithParentCategoryDto>(category);
            }

            return createCategoryResponse;
        }
    }
}
