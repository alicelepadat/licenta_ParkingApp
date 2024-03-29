﻿using AutoMapper;
using ParkingApp.Main.DataAcces.UnitOfWork;
using ParkingApp.Main.DomainModels;
using ParkingApp.Main.Dtos;
using ParkingApp.Main.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingApp.Main.Services
{
    public class ParkingAreaService : IParkingAreaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ParkingAreaService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<ParkingAreaDto>> GetAllAreasAsync()
        {
            var models = await _unitOfWork.ParkingAreaRepository.GetAllAreasAsync();

            return _mapper.Map<IEnumerable<ParkingArea>, IEnumerable<ParkingAreaDto>>(models);
        }

        public async Task<ParkingAreaDto> GetAreaByIdAsync(int id)
        {
            var model = await _unitOfWork.ParkingAreaRepository.GetByIdAsync(id);

            return _mapper.Map<ParkingArea, ParkingAreaDto>(model);
        }

        public async Task<ParkingAreaDto> GetAreaByNameAsync(string emplacement)
        {
            var model = await _unitOfWork.ParkingAreaRepository.SingleOrDefaultAsync(a => a.Emplacement.ToLower() == emplacement.ToLower());

            return _mapper.Map<ParkingArea, ParkingAreaDto>(model);
        }

        public async Task UpdateAvailableSpotsAsync(ParkingAreaDto parkingArea)
        {
            var model = await _unitOfWork.ParkingAreaRepository.SingleOrDefaultAsync(a => a.Id == parkingArea.Id);

            if (model.AvailableSpots < model.TotalSpots && model.AvailableSpots >= 0)
            {
                model.AvailableSpots += 1;
            }

            await _unitOfWork.CommitAsync();
        }
    }
}
