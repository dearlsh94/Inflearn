using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ProjectNC01.Models
{
    public class StudentModel
    {
        /**
        * prop + tab + tab 시 인텔리센스를 이용한 빠른 Property 선언 가능
        * { get; set; } : 자동으로 getter 및 setter 인식
        * [MaxLength(50)] : 50 자 이내
        * [Range(15, 70)] : 15 이상, 70 이하 값
        * [MinLength(5)] : 최소 5 글자 이상
        * [Required] : 필수 입력
        * [BindNever] : Post 전송 시 해당 데이터 바인딩 제외 (Controller로 넘겨주지 않음.)
        **/
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required, Range(15, 70)]
        public int Age { get; set; }
        [MinLength(5)]
        public string Country { get; set; }
        [BindNever]
        public string Nodata { get; set; }
    }
}
