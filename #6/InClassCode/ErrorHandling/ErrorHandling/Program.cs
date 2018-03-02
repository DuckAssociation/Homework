using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                throw new NullReferenceException("Ups something wrong happen",
                    new ArgumentException());
            }
            catch (ArgumentException ex)
            {
                // Logic to handle Argument exception.
            }
            catch (NullReferenceException ex)
            {
                // Logic to handle NullReference exception.
            }
            catch
            {
                // Will catch all exceptions.
            }
            finally
            {
                // Will always execute so you can i.e. clean up resources.
            }

            throw new ArgumentException("Invalid argument");

            return -1;
        }

    }
}
