using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PaintBallManager.Models
{
    public class Player
    {
        [Key]
        public int playerId { get; set; }
        public IEnumerable<double> amoutOwed { get; set; }        
        
    }
}