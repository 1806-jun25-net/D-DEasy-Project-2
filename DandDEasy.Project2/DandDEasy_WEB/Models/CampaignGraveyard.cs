﻿using System;
using System.Collections.Generic;

namespace DandDEasy_WEB
{
    public partial class CampaignGraveyard
    {
        public int Id { get; set; }
        public int? CampaignId { get; set; }
        public int? CharacterId { get; set; }

        public Campaign Campaign { get; set; }
        public Character Character { get; set; }
    }
}