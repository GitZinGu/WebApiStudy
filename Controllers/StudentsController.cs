using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class StudentsController : ApiController
    {
        List<Student> li = null;
        public List<Student> Get()
        {

                li= new List<Student>() { 
                new Student() { Name = "zhangsan1", Age = 1 ,ID=1},
                new Student() { Name = "zhangsan2", Age = 2 ,ID=2},
                new Student() { Name = "zhangsan3", Age = 3 ,ID=3},
                new Student() { Name = "zhangsan4", Age = 4 ,ID=4},
                new Student() { Name = "zhangsan5", Age = 5 ,ID=5},
                new Student() { Name = "zhangsan6", Age = 6 ,ID=6},
                new Student() { Name = "zhangsan7", Age = 7 ,ID=7},     
            };
            return li;
        }
        public Student GetAdress(int id)
        {
                li= new List<Student>() {
                 new Student() { Name = "zhangsan1", Age = 1 ,ID=1},
                new Student() { Name = "zhangsan2", Age = 2 ,ID=2},
                new Student() { Name = "zhangsan3", Age = 3 ,ID=3},
                new Student() { Name = "zhangsan4", Age = 4 ,ID=4},
                new Student() { Name = "zhangsan5", Age = 5 ,ID=5},
                new Student() { Name = "zhangsan6", Age = 6 ,ID=6},
                new Student() { Name = "zhangsan7", Age = 7 ,ID=7},
            };

            var list= li.Where(t=>t.ID== id).ToList();
            return list[0];
        }
        public string Get(string name)
        {
            return "名字" + name;
        }
        
        public void Post(Student stu) 
        {
        
        }
        public void Put(int id,string name,Student stu) 
        {
        
        }
        public void delete(int id)
        { 
        
        }

    }
}
