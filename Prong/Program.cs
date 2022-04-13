//Programa criado seguindo o tutorial de "Prong" de "O Programador", disponível no Youtube.

using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Prong1
{
    class Program : GameWindow
    {
        int xDaBola = 0;
        int yDaBola = 0;
        int tamanhoDaBola = 20;
        int velocidadeDaBolaEmX = 3;
        int velocidadeDaBolaEmY = 3;
        int yDoJogador1 = 0;
        int yDoJogador2 = 0;

        //Métodos abaixo definem o tamanho das raquetes
        int xDoJogador1() 
        {
            return -ClientSize.Width / 2 + larguraDosJogadores() / 2;
        }

        int xDoJogador2() 
        {
            return ClientSize.Width / 2 - larguraDosJogadores() / 2;
        }

        int larguraDosJogadores() 
        {
            return tamanhoDaBola;
        }

        int alturaDosJogadores()
        {
            return 3 * tamanhoDaBola;
        }

        //OnUpdateFrame() e OnRenderframe são as funções do OpenTK responsáveis pelo Game Loop
        protected override void OnUpdateFrame(FrameEventArgs e) //função que ocorre ao atualizar o estado do jogo
        {
            xDaBola = xDaBola + velocidadeDaBolaEmX;
            yDaBola = yDaBola + velocidadeDaBolaEmY;

            //checadores de colisão (travam objetos dentro da cena)
            if (xDaBola + tamanhoDaBola / 2 > xDoJogador2() - larguraDosJogadores() / 2
                && yDaBola - tamanhoDaBola / 2 < yDoJogador2 + alturaDosJogadores() / 2
                && yDaBola + tamanhoDaBola / 2 > yDoJogador2 - alturaDosJogadores() / 2) 
            {
                velocidadeDaBolaEmX = -velocidadeDaBolaEmX;
            }

            if (xDaBola - tamanhoDaBola / 2 < xDoJogador1() + larguraDosJogadores() / 2
                && yDaBola - tamanhoDaBola / 2 < yDoJogador1 + alturaDosJogadores() / 2
                && yDaBola + tamanhoDaBola / 2 > yDoJogador1 - alturaDosJogadores() / 2)
            {
                velocidadeDaBolaEmX = -velocidadeDaBolaEmX;
            }

            //Métodos abaixo fazem a bola "quicar" quando ela bate nos cantos superior ou inferior da tela
            if (yDaBola + tamanhoDaBola / 2 > ClientSize.Height / 2)
            {
                velocidadeDaBolaEmY = -velocidadeDaBolaEmY;
            }

            if (yDaBola - tamanhoDaBola / 2 < -ClientSize.Height / 2)
            {
                velocidadeDaBolaEmY = -velocidadeDaBolaEmY;
            }

            //Este método reseta a bola quando ela sai pelas laterais
            if (xDaBola < -ClientSize.Width / 2 || xDaBola > ClientSize.Width / 2) 
            {
                xDaBola = 0;
                yDaBola = 0;
            }

            //Quatro métodos abaixo são checadores das teclas de movimento das raquetes
            if (Keyboard.GetState().IsKeyDown(Key.W)) 
            {
                yDoJogador1 = yDoJogador1 + 5;
            }

            if (Keyboard.GetState().IsKeyDown(Key.S)) 
            {
                yDoJogador1 = yDoJogador1 - 5;
            }

            if (Keyboard.GetState().IsKeyDown(Key.Up))
            {
                yDoJogador2 = yDoJogador2 + 5;
            }

            if (Keyboard.GetState().IsKeyDown(Key.Down))
            {
                yDoJogador2 = yDoJogador2 - 5;
            }

            //Quadro métodos abaixo são detectores de colisão das raquetes
            if (yDoJogador1 + alturaDosJogadores() / 2 > ClientSize.Height / 2) 
            {
                yDoJogador1 = ClientSize.Height / 2 - alturaDosJogadores() / 2;
            }

            if (yDoJogador2 + alturaDosJogadores() / 2 > ClientSize.Height / 2)
            {
                yDoJogador2 = ClientSize.Height / 2 - alturaDosJogadores() / 2;
            }

            if (yDoJogador1 - alturaDosJogadores() / 2 < -ClientSize.Height / 2)
            {
                yDoJogador1 = -ClientSize.Height / 2 + alturaDosJogadores() / 2;
            }

            if (yDoJogador2 - alturaDosJogadores() / 2 < -ClientSize.Height / 2)
            {
                yDoJogador2 = -ClientSize.Height / 2 + alturaDosJogadores() / 2;
            }

        }
        protected override void OnRenderFrame(FrameEventArgs e) //função que ocorre ao desenhar o estado do jogo
        {
            //Console.WriteLine(ClientSize.Width + " " + ClientSize.Height);
     
            GL.Viewport(0, 0, ClientSize.Width, ClientSize.Height);

            Matrix4 projection = Matrix4.CreateOrthographic(ClientSize.Width, ClientSize.Height, 0.0f, 1.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);

            GL.Clear(ClearBufferMask.ColorBufferBit);

            //Parâmetros para os desenhos da bola e das raquetes e suas cores
            DesenharRetangulo(xDaBola, yDaBola, tamanhoDaBola, tamanhoDaBola, 1.0f, 1.0f, 0.0f);
            DesenharRetangulo(xDoJogador1(), yDoJogador1, larguraDosJogadores(), alturaDosJogadores(), 1.0f, 0.0f, 0.0f);
            DesenharRetangulo(xDoJogador2(), yDoJogador2, larguraDosJogadores(), alturaDosJogadores(), 0.0f, 0.0f, 1.0f);

            SwapBuffers();
        }

        //Método que serve para definir as bolas e raquetes
        void DesenharRetangulo(int x, int y, int largura, int altura, float r, float g, float b) 
        {
            GL.Color3(r, g, b);

            GL.Begin(PrimitiveType.Quads); //Este comando é o início do desenho de um quadrado
            GL.Vertex2(-0.5f * largura + x, -0.5f * altura + y); //Estas quatro funções dizem onde serão os vértices do quadrado, na tela, aqui considerada um plano cartesiano
            GL.Vertex2(0.5f * largura + x, -0.5f * altura + y);
            GL.Vertex2(0.5f * largura + x, 0.5f * altura + y);
            GL.Vertex2(-0.5f * largura + x, 0.5f * altura + y);
            GL.End(); //este comando é o fim do desenho de um quadrado

        }

        static void Main()
        {
            new Program().Run();
        }
    }
}
