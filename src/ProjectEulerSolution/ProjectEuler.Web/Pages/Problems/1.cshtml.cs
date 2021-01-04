using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectEuler.Problem1;
using System.ComponentModel.DataAnnotations;

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
            Output = new OutputValues
            {
                Result = _calculator.Calc(Input.N),
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
            public int N { get; set; }

            public static InputValues Default => new InputValues
            {
                N = 0,
            };
        }

        /// <summary>
        /// 出力クラス
        /// </summary>
        public class OutputValues
        {
            public int Result { get; set; }

            public bool IsNone => this is NoOutput;

            public static OutputValues None => new NoOutput();

            private class NoOutput : OutputValues
            {
            }
        }
    }
}
