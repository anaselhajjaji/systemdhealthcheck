﻿using MediatR;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Events
{
    public class DeleteAllEvent : IRequest<bool>
    {
    }
}