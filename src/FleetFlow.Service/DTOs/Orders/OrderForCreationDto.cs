﻿using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.DTOs.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.DTOs.Orders
{
    public class OrderForCreationDto
    {
        public AddressForCreationDto AddressDto { get; set; }
        public PaymentCreationDto PaymentCreationDto { get; set; }
        public AttachmentCreationDto AttachmentCreationDto { get; set; }
    }
}
