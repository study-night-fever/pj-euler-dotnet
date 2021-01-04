using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectEuler.Problem1;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ProjectEuler.Web.Pages.Problems
{
    public class Problem1PageModel : BaseProblemPageModel
    {
        public override int ProblemId => 1;

        private readonly ICalculator _calculator;

        public Problem1PageModel(ILogger<Problem1PageModel> logger, ICalculator calculator)
            : base(logger)
        {
            _calculator = calculator;
        }

        public void OnGet()
        {
            Input = InputValues.Default;
            Output = OutputValues.None;
        }

        public void OnPost()
        {
            var list = _calculator.List(Input.Value);

            Output = new OutputValues
            {
                Sum = list.Sum(),
                List = list,
            };
        }

        /// <summary>
        /// 入力
        /// </summary>
        [BindProperty]
        public InputValues Input { get; set; }

        /// <summary>
        /// 出力
        /// </summary>
        public OutputValues Output { get; set; }

        /// <summary>
        /// 入力クラス
        /// </summary>
        public class InputValues
        {
            [Required]
            [Range(0, int.MaxValue)]
            public int Value { get; set; }

            public static InputValues Default => new InputValues
            {
                Value = 0,
            };
        }

        /// <summary>
        /// 出力クラス
        /// </summary>
        public class OutputValues
        {
            public int Sum { get; set; }

            public IEnumerable<int> List { get; set; }

            public bool IsNone => this is NoOutput;

            public static OutputValues None => new NoOutput();

            private class NoOutput : OutputValues
            {
                public NoOutput()
                {
                    Sum = 0;
                    List = Enumerable.Empty<int>();
                }
            }
        }
    }
}
