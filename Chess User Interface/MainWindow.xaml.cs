using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Chess_Logics;

namespace Chess_User_Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private readonly Image[,] pieceimages = new Image[8,8];

        private GameState gamestate;

        public MainWindow()
        {
            InitializeComponent();
            InitializeBoard();

            gamestate = new GameState(Player.White, Board.Initial());
            DrawBoard(gamestate.Board);
        }


        private void InitializeBoard()
        {
            for (int r = 0; r < 8; r++)
            {
                for(int c = 0; c < 8; c++)
                {
                    Image image = new Image();
                    pieceimages[r, c] = image;
                    PieceGrid.Children.Add(image);
                }
            }
        }

        private void DrawBoard(Board board)
        {
            for (int r= 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    Piece piece = board[r,c];
                    pieceimages[r,c].Source = Images.GetImage(piece);
                }
            }
        }


    }
}