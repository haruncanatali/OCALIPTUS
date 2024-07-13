using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OCALIPTUS.Application.Common.Exceptions;
using OCALIPTUS.Application.Common.Interfaces;
using OCALIPTUS.Application.Common.Managers;
using OCALIPTUS.Application.Common.Models;
using OCALIPTUS.Domain.Enums;
using OCALIPTUS.Domain.Identity;

namespace OCALIPTUS.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<BaseResponseModel<long>>
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public IFormFile? ProfilePhoto { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public string IdentityNumber { get; set; }

        public Gender Gender { get; set; }
        public Nationality Nationality { get; set; }
        public MemberStatus MemberStatus { get; set; }

        public class Handler : IRequestHandler<UpdateUserCommand, BaseResponseModel<long>>
        {
            private readonly UserManager<User> _userManager;
            private readonly IApplicationContext _context;
            private readonly FileManager _fileManager;

            public Handler(IApplicationContext context, FileManager fileManager, UserManager<User> userManager)
            {
                _context = context;
                _fileManager = fileManager;
                _userManager = userManager;
            }

            public async Task<BaseResponseModel<long>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
            {
                try
                {
                    User? entity = await _context.Users.FirstOrDefaultAsync(x => x.Id == request.Id);

                    if (entity == null)
                        throw new BadRequestException("Güncellenecek kullanıcı bulunamadı.");

                    entity.FirstName = request.FirstName;
                    entity.Surname = request.Surname;
                    entity.Email = request.Email;
                    entity.Gender = request.Gender;
                    entity.ProfilePhoto = _fileManager.Upload(request.ProfilePhoto,FileRoot.UserProfile);
                    entity.PhoneNumber = request.Phone;
                    entity.Birthdate = request.Birthdate;
                    entity.IdentityNumber = request.IdentityNumber;
                    entity.MemberStatus = request.MemberStatus;
                    entity.Nationality = request.Nationality;
                    entity.Age = request.Age;
                    
                    await _userManager.UpdateAsync(entity);

                    if (!string.IsNullOrEmpty(request.Password))
                    {
                        var removeResult = await _userManager.RemovePasswordAsync(entity);
                        if (removeResult.Succeeded)
                        {
                            await _userManager.AddPasswordAsync(entity, request.Password);
                        }
                        else
                        {
                            throw new BadRequestException(
                                $"(UUC-0) Kullanıcı güncellenirken şifre değiştirme sırasında hata meydana geldi.");
                        }
                    }
                    
                    return BaseResponseModel<long>.Success(entity.Id,$"Kullanıcı başarıyla oluşturuldu. Username: {request.Email}");
                }
                catch (Exception e)
                {
                    throw new BadRequestException(
                        $"({request.Email}) Kullanıcı oluşturulurken hata meydana geldi. Hata: {e.Message}");
                }
            }
        }
    }
}