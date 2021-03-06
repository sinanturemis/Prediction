﻿using System;

namespace PredictionApp.Service
{
    public class UpdateCustomerRequest : RequestBase
    {
        public Guid ID { get; set; }
        public byte Age { get; set; }
        public bool GenderType { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int? LocationGroupId { get; set; }
        public int VisitCountInYear { get; set; }
    }
}
