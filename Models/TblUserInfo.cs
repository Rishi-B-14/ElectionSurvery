using System;
using System.Collections.Generic;

namespace FeedbackProject.Models;

public partial class TblUserInfo
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Village { get; set; }

    public string? PhoneNum { get; set; }
}
