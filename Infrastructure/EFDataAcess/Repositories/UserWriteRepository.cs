﻿using Application.Repositories;
using AutoMapper;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Infrastructure.EFDataAcess.Repositories
{
    public class UserWriteRepository : IUserWriteOnlyRepository
    {
        private readonly UserContext _context;
        private IMapper _mapper;

        public UserWriteRepository(UserContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<User> Add(User user)
        {
            if (user != null)
            {
                Entities.User userDTO = _mapper.Map<Entities.User>(user);
                _context.users.Add(userDTO);
                _context.SaveChanges();
                return user;
            }
            return null;
        }

        public async Task<Information> AddInformation(Information information)
        {
            if (information != null)
            {
                Entities.Information informationDTO = _mapper.Map<Entities.Information>(information);
                _context.information.Add(informationDTO);
                _context.SaveChanges();
                return information;
            }
            return null;
        }

        public async Task<User> Delete(int id)
        {
            var u = await _context.users.FindAsync(id);
            if (u == null)
            {
                return null;
            }

            _context.users.Remove(u);
            await _context.SaveChangesAsync();
            User userDTO = _mapper.Map<User>(u);
            return userDTO;
        }

        public async Task<Information> DeleteInformation(int id)
        {
            var u = await _context.information.FindAsync(id);
            if (u == null)
            {
                return null;
            }

            _context.information.Remove(u);
            await _context.SaveChangesAsync();
            Information informationDTO = _mapper.Map<Information>(u);
            return informationDTO;
        }

        public async Task<User> Update(int id, User user)
        {
            if (id != user.UserId)
            {
                return null;
            }
            Entities.User userDTO = _mapper.Map<Entities.User>(user);
            _context.Entry(userDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await _context.users.FindAsync(id) == null)
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

            return user;
        }

        public async Task<Information> UpdateInformation(int id, Information information)
        {
            if (id != information.InformationId)
            {
                return null;
            }
            Entities.Information informationDTO = _mapper.Map<Entities.Information>(information);
            _context.Entry(informationDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await _context.information.FindAsync(id) == null)
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
            return information;
        }
    }
}