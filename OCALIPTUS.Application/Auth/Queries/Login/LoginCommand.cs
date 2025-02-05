﻿using MediatR;
using Microsoft.AspNetCore.Identity;
using OCALIPTUS.Application.Auth.Queries.Login.Dtos;
using OCALIPTUS.Application.Common.Exceptions;
using OCALIPTUS.Application.Common.Interfaces;
using OCALIPTUS.Application.Common.Managers;
using OCALIPTUS.Application.Common.Mappings;
using OCALIPTUS.Application.Common.Models;
using OCALIPTUS.Domain.Identity;

namespace OCALIPTUS.Application.Auth.Queries.Login
{
    public class LoginCommand : IRequest<BaseResponseModel<LoginDto>>, IMapFrom<User>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string DeviceToken { get; set; }

        public class Handler : IRequestHandler<LoginCommand, BaseResponseModel<LoginDto>>
        {
            private readonly SignInManager<User> _signInManager;

            private readonly TokenManager _tokenManager;
            private readonly UserManager<User> _userManager;
            private readonly IApplicationContext _context;

            public Handler(SignInManager<User> signInManager, TokenManager tokenManager, UserManager<User> userManager,
                IApplicationContext context)
            {
                _signInManager = signInManager;
                _tokenManager = tokenManager;
                _userManager = userManager;
                _context = context;
            }

            public async Task<BaseResponseModel<LoginDto>> Handle(LoginCommand request, CancellationToken cancellationToken)
            {
                LoginDto loginViewModel = new LoginDto();
                User? appUser = await _userManager.FindByEmailAsync(request.Username);
                if (appUser != null)
                {
                    SignInResult result = await _signInManager.PasswordSignInAsync(appUser.UserName, request.Password,
                        false, false);

                    if (result.Succeeded)
                    {
                        loginViewModel = await _tokenManager.GenerateToken(appUser);
                        appUser.RefreshToken = loginViewModel.RefreshToken;
                        appUser.RefreshTokenExpiredTime = loginViewModel.RefreshTokenExpireTime;
                        await _userManager.UpdateAsync(appUser);
                        return BaseResponseModel<LoginDto>.Success(data: loginViewModel,$"Kullanıcı başarıyla giriş yaptı. Kullanıcı :{request.Username}");
                    }
                }
                
                throw new BadRequestException($"Giriş yapılmak istenen kullanıcı bulunamadı. Kullanıcı adı :{request.Username}");
            }
        }
    }
}