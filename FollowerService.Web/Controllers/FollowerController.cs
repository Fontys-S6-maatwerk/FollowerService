﻿using FollowerService.Data;
using FollowerService.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FollowerService.Web.Controllers
{
    [ApiController]
    [Route("api/")]
    public class FollowerController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        private readonly ILogger<FollowerController> _logger;

        public FollowerController(ILogger<FollowerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("online")]
        public string checkOnline()
        {
            return "Check if API is availabe";
        }

        [HttpPost]
        public ActionResult<User> FollowUser([FromBody] User userDto)
        {
            _context.User.Add(userDto);
            try
            {
                _context.SaveChanges();
            } catch (Exception)
            {
                return StatusCode(500);
            }

            return StatusCode(201);
        }

        [HttpPost]
        public ActionResult<User> FollowSDF([FromBody] SDG sdgDto)
        {
            _context.SDG.Add(sdgDto);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

            return StatusCode(201);
        }
    }
}