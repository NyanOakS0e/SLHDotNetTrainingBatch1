﻿using System;
using System.Collections.Generic;

namespace SLHDotNetTrainingBatch1.Project1.Databases.Models;

public partial class TblUser
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;
}
