/** 
* HighBeta Dream.Build.Play 2012 http://github.com/mcolonj/Dream.Build.Play.2012
*
* Copyright (c) Michael Colon
* Copyright (c) 2012 HighBeta, LLC.
*
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
**/


// Uncomment the define below to run in debug mode.
//#define HIGHBETA_DEBUG
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace Dream.Build.Play._2012
{


#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        
        static void Main(string[] args)
        {
#if HIGHBETA_DEBUG

            Console.WriteLine("------------------ debug mode started ----------------");
            // debug code here
            Console.WriteLine("------------------ debug mode ended ----------------");

#else
            Console.WriteLine("run mode");
            using (Game1_alt game = new Game1_alt())
            {
                game.Run();
            }
#endif
        }

    }
#endif
}

