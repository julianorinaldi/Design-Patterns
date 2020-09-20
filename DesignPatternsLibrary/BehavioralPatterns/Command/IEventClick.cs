using System;

namespace DesignPatterns.BehavioralPatterns.Command
{
    public interface IEventClick
    {
        public void OnClick(object sender, EventArgs e);
    }
}