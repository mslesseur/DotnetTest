using AutoMapper;
using dotnet_test;
using dotnet_test.Dtos;
using dotnet_test.Dtos.User;
using dotnet_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_test.Services.UserService
{
    public class UserService : IUserService
    {
        private static List<User> users = new List<User>{
            new User(),
            new User {Id = 1, Name = "Minho"}
        };
        private readonly IMapper _mapper;

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }


        //ServiceResponse

        //Add Character
        public async Task<ServiceResponse<List<GetUserDto>>> AddUser(AddUserDto newUser)
        {
            var serviceResponse = new ServiceResponse<List<GetUserDto>>();
            User user = _mapper.Map<User>(newUser);
            user.Id = users.Max(c => c.Id) + 1;
            users.Add(user);
            serviceResponse.Data = users.Select(c => _mapper.Map<GetUserDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetUserDto>>> DeleteUser(int id)
        {
            ServiceResponse<List<GetUserDto>> response = new ServiceResponse<List<GetUserDto>>();
            try
            {
                User user = users.First(c => c.Id == id);
                users.Remove(user);
                response.Data = users.Select(c => _mapper.Map<GetUserDto>(c)).ToList();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        //Get All Characters
        public async Task<ServiceResponse<List<GetUserDto>>> GetAllUsers()
        {
            return new ServiceResponse<List<GetUserDto>>
            {
                Data = users.Select(c => _mapper.Map<GetUserDto>(c)).ToList()
            };
        }

        //Get Character By Id
        public async Task<ServiceResponse<GetUserDto>> GetUserById(int id)
        {
            var serviceResponse = new ServiceResponse<GetUserDto>();
            var user = users.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetUserDto>(user);
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetUserDto>> UpdateUser(UpdateUserDto updatedUser)
        {
            ServiceResponse<GetUserDto> response = new ServiceResponse<GetUserDto>();
            try
            {
                User user = users.FirstOrDefault(c => c.Id == updatedUser.Id);

                //Automapper
                //_mapper.Map(updatedCharacter, character);

                user.Name = updatedUser.Name;
                user.Email = updatedUser.Email;
                user.Phone = updatedUser.Phone;
                user.Type = updatedUser.Type;

                response.Data = _mapper.Map<GetUserDto>(user);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
