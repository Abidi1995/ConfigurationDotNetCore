using ConfigurationDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
    public class LibraryController : Controller
    {

        private readonly CompanyContext _context;
        public LibraryController(CompanyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var LibraryList = _context.Libraries.ToList();
            return View(LibraryList);
        }
        //Create Library
        [HttpPost]
        public string Create(Library library)
        {
            try//try block
            {
                _context.Libraries.Add(library);
                _context.SaveChanges();//Save date into table library
                return "success";

            }
            catch (Exception ex)//catch block
            {

                return ex.Message;
            }
           
        }
        //Edit:Library method
        [HttpGet]
        public ActionResult EditLibrary(int id)
        {
            var editLib = _context.Libraries.Where(h => h.LibraryID == id).FirstOrDefault();
            return View(editLib);
        }
        [HttpPost]//post method of edit
        public string EditLibary(Library library)
        {
            var edit = _context.Libraries.Find(library.LibraryID);
            if (edit != null)//check for null 
            {
                edit.LibraryName = library.LibraryName;
                edit.Code= library.Code;
                edit.OpeningTime = library.OpeningTime;
                edit.ClosingTime = library.ClosingTime;
                _context.SaveChanges();


            }
            else
            {
                return "failed to edit libaray";
            }
            return "edited successfully";
        }
        // Delete method for library
        public ActionResult DeleteLibrary(int id)
        {
            var delete = _context.Libraries.Where(h => h.LibraryID == id).FirstOrDefault();//Compairing Id
            return View(delete);
        }
        [HttpPost]
        public string DeleteLibrary(Library library)
        {
            var find = _context.Libraries.Find(library.LibraryID);
            if (find != null)
            {
                _context.Libraries.Remove(find);
                _context.SaveChanges();
            }
            else
            {
                return "failed to delete";
            }
            return " Libaray Deleted deleted";

        }
        //Edit:BookList
        [HttpGet]
        public ActionResult EditBookList(int id)
        {
            var Blist = _context.Libraries.Where(h => h.LibraryID == id).FirstOrDefault();
            return View(Blist);
        }
        public string EditBookList(LibrarayBookList list)
        {
            var EditList = _context.LibrarayBookLists.Find(list.LibrayBookListID);
            if (EditList != null)
            {
                EditList.AccessionNo = list.AccessionNo;
                EditList.Author = list.Author;
                EditList.ClassificationNo = list.ClassificationNo;
                EditList.EntryDate = list.EntryDate;
                EditList.Edition = list.Edition;
                EditList.Language = list.Language;
                EditList.Publisher = list.Publisher;
                EditList.VolumeNo = list.VolumeNo;
                EditList.Language = list.Language;
                EditList.PresentPosition = list.PresentPosition;
                EditList.Source = list.Source;
                EditList.TranslatorCorner = list.TranslatorCorner;
                EditList.Subject = list.Subject;
                EditList.Remarks = list.Remarks;
                EditList.Pages = list.Pages;
                _context.SaveChanges();
            }
            else
            {
                return "not edited";
            }
            return "edited";
        }
        //public ActionResult DeleteBookList(int id)
        //{
        //    var ff = _context.LibrarayBookLists.Where(n => n.ID == id);
        //    return View(ff);
        //}
        //public async Task<string>DeleteBookList(LibrarayBookList bookList)
        //{
        //    var find = _context.LibrarayBookLists.Find(bookList.ID);
        //    if (find != null)
        //    {
        //        try
        //        {
        //            var BookRecordList = _context.LibraryBookRecords.Where(n => n.LibraryBookListId == bookList.ID).ToList();
        //            var BookIssuedList = _context.LibraryIssuedBooks.Where(W => W.LibraryBookRecordId == bookList.ID).ToList();
        //            foreach (var item in LibraryBookRecord)
        //            {
        //                if (item.LibraryIssuedBooksToStaffs != null)
        //                {
        //                    _context.LibraryIssuedBooksToStaffs.Remove(BookIssuedList);
        //                }
        //                _context.LibraryBookRecords.Remove(item);
        //            }
        //            foreach (var item in LibraryIssuedBooks)
        //            {
        //                _context.LibraryIssuedBooks.Remove(item);
        //            }
        //            _context.LibrarayBookLists.Remove(LibrarayBookList);
        //            await _context.SaveChanges();

        //        }
        //        catch (Exception ex)
        //        {

        //            return ex.Message;
        //        }
                
                
            }
            
        }
        
    
   

