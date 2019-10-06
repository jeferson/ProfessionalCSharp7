﻿using System;

namespace NoDI
{
    public class HomeController
    {
        private readonly IGreetingService _greetingService;

        public HomeController(IGreetingService greetingService)
        {
            _greetingService = greetingService ?? throw new ArgumentNullException(nameof(greetingService));
        }

        public string Hello(string name)
        {
            return _greetingService.Greet(name);
        }
    }
}
