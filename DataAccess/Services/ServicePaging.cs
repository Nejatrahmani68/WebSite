//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.Services
//{
//        public class ServicePaging<T> : List<T>
//        {

//            public ServicePaging(IEnumerable<T> currentPage, int count, int pageNumber, int pageSize)
//            {
//                CurrentPage = pageNumber;
//                TotalPages = (int)Math.Ceiling(count / (double)pageSize);
//                PageSize = pageSize;
//                TotalCount = count;
//                AddRange(currentPage);
//            }

//            public int CurrentPage { get; set; }
//            public int TotalPages { get; set; }
//            public int PageSize { get; set; }
//            public int TotalCount { get; set; }

//            public static async Task<ServicePaging<T>> CreateAsync(IQueryable<T> source, int pageNumber, int pageSize)
//            {
//                var count = await source.CountAsync();
//                var items = await source.Skip((pageNumber) * pageSize).Take(pageSize).ToListAsync();
//                return new ServicePaging<T>(items, count, pageNumber, pageSize);
//            }
//        }
//    }
//}
