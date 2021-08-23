#nullable enable
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace CST150W3A7
{
    public partial class Form1 : Form {
        private const decimal Numerator = 4;
        private int _iterations = 0;
        private readonly Stopwatch _stopwatch;

        public Form1() {
            InitializeComponent();
            _stopwatch = new Stopwatch();
            FormClosing += OnFormClosing;
            Icon = new Icon("pi.ico");
            currentIterationLbl.Text = "0 iterations";
        }

        private async void OnFormClosing(object? sender, FormClosingEventArgs e) {
            // async keyword used for future references to any async
            // operation during the close routine
            switch (e.CloseReason) {
                case CloseReason.None:
                    e.Cancel = true;
                    return;
                case CloseReason.WindowsShutDown:
                    break;
                case CloseReason.MdiFormClosing:
                    break;
                case CloseReason.UserClosing:
                    break;
                case CloseReason.TaskManagerClosing:
                    break;
                case CloseReason.FormOwnerClosing:
                    break;
                case CloseReason.ApplicationExitCall:
                    break;
                default:
                    MethodBase? declaringMethod = GetType().DeclaringMethod;
                    if (declaringMethod is not null)
                        throw new ArgumentOutOfRangeException(nameof(e.CloseReason), e.CloseReason, "Value is invalid.") {
                            HelpLink = "",
                            HResult = -1,
                            Source = declaringMethod.Name
                        };
                    break;
            }

            NativeMethods.FreeConsole();
            await Task.Delay(1).ConfigureAwait(false);
        }

        private async Task< (decimal, long) > CalculatePiApproximation(ulong terms) {
            _iterations = 0;
            decimal res = Numerator;
            _stopwatch.Reset();
            _stopwatch.Start();
            for (ulong u = 1; u < terms*2; u += 2) {
                if (_iterations % 2 == 0) {
                    // Even subtracts the left from the right
                    res -= Numerator / ( u + 2 );
                }
                else {
                    // Odd adds the left to the right.
                    res += Numerator / ( u + 2 );
                }

                _iterations++;
                Task.Run(UpdateIterations);
            }

            _stopwatch.Stop();
            return ( res, _stopwatch.ElapsedMilliseconds );
        }

        private void UpdateIterations() {
            if (InvokeRequired) {
                Invoke(new Action(UpdateIterations));
                return;
            }

            currentIterationLbl.Text = $"{_iterations} iterations passed...";
            Application.DoEvents();
        }

        private async void CalculateBtn_Click(object sender, EventArgs e)
        {
            calculateBtn.Enabled = false;
            progressBar.Visible = true;
            outputTxt.Clear();

            _ = ulong.TryParse(inputTxt.Text, out ulong terms);
            decimal result = 0m;
            long millis = 0L;

            await Task.Factory.StartNew(async () => { (result, millis) = await CalculatePiApproximation(terms); });

            outputTxt.Text = $"{result}";
            MessageBox.Show(this,
                            $"Result: {result}\nTime taken: {TimeSpan.FromMilliseconds(millis):G}");

            progressBar.Visible = false;
            calculateBtn.Enabled = true;
        }
    }
}