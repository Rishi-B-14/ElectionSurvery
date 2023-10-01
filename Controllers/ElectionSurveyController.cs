﻿//using FeedbackProject.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace FeedbackProject.Controllers;
//[ApiController]
//public class ElectionSurveyController : ControllerBase
//{
//    private readonly SurveyProjectContext dbcontext;
//    public ElectionSurveyController(SurveyProjectContext _dbcontext)
//    {
//        dbcontext = _dbcontext;
//    }

//    [HttpPost]
//    [Route("/[Controller]/[Action]")]
//    public IActionResult GetUser(TblUserDetail userInfo)
//    {
//        try
//        {
//            if(userInfo.Id == 0)
//            {
//                var userLst = dbcontext.TblUserDetails.ToList();
//                return Ok(userLst);
//            }
//            var user = dbcontext.TblUserDetails.FirstOrDefault(x => x.Id == userInfo.Id);
//            return Ok(user);
//        }
//        catch (Exception ex) { return BadRequest(ex.Message); }
//    }

//    [HttpPost]
//    [Route("/[Controller]/[Action]")]
//    public IActionResult AddUser(TblUserDetail userInfo)
//    {
//        try
//        {
//            var existUser = dbcontext.TblUserDetails.FirstOrDefault(u => u.PhoneNum == userInfo.PhoneNum);
//            if (existUser != null)
//                return BadRequest("Mobile num already registered!");

//            var product = dbcontext.TblProducts.FirstOrDefault(p => p.ProductName == userInfo.SelectedProduct);
//            if (product == null)
//                return BadRequest("Select a valid product");

//            TblUserDetail tblUser = new TblUserDetail();
//            tblUser.Id = dbcontext.TblUserInfos.Max(x => x.Id) + 1;
//            tblUser.Name = userInfo.Name;
//            tblUser.Age = userInfo.Age;
//            tblUser.City = userInfo.City;
//            tblUser.PhoneNum = userInfo.PhoneNum;
//            tblUser.FamilyMembers = userInfo.FamilyMembers;
//            tblUser.SelectedProduct = userInfo.SelectedProduct;
//            tblUser.SubmissionTime = DateTime.Now;
//            dbcontext.TblUserDetails.Add(tblUser);
//            dbcontext.SaveChanges();
//            return Ok("Added Successfully");
//        }
//        catch (Exception ex) { return BadRequest(ex.Message); }
//    }

//    [HttpPost]
//    [Route("/[Controller]/[Action]")]
//    public IActionResult UpdateUser(TblUserDetail userInfo)
//    {
//        try
//        {
//            dbcontext.TblUserDetails.Update(userInfo);
//            dbcontext.SaveChanges();
//            return Ok("Update successfully");
//        }
//        catch (Exception ex) { return BadRequest(ex.Message); }
//    }

//    [HttpPost]
//    [Route("/[Controller]/[Action]")]
//    public IActionResult DeleteUser(TblUserDetail userInfo)
//    {
//        try
//        {
//            return Ok();
//        }
//        catch (Exception ex) { return BadRequest(ex.Message); }
//    }
//}


////Data Source = DESKTOP - 8VEE66M\SQLEXPRESS; Initial Catalog = SurveyProject; Integrated Security = True