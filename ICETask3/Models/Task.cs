using System;
using System.Collections.Generic;

namespace ICETask3.Models;

public partial class Tasks
{
    public int TaskId { get; set; }

    public string? TaskName { get; set; }

    public string? TaskDescription { get; set; }

    public string? TaskStatus { get; set; }
}
