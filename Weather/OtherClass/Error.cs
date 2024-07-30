namespace Weather
{
    public static class Error
    {
        public static string[] msg = new string[9];



        public static void HandleError(Exception exception)
        {
            msg[0] = "Object reference not set to an instance of an object.";
            msg[1] = "Value cannot be null. Parameter name: [parameter name]";
            msg[2] = "Index was outside the bounds of the array.";
            msg[3] = "Operation is not valid due to the current state of the object.";
            msg[4] = "Arithmetic operation resulted in an overflow.";
            msg[5] = "Exception of type 'System.OutOfMemoryException' was thrown.";
            msg[6] = "Exception of type 'System.StackOverflowException' was thrown.";
            msg[7] = "The operation has timed out.";
            msg[8] = "The method or operation is not implemented.";




            if (exception is NullReferenceException)
            {
                MessageBox.Show("Class reference is not initiliazed", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (exception is ArgumentNullException)
            {
                MessageBox.Show("Value cannot be empty", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (exception is IndexOutOfRangeException)
            {
                MessageBox.Show("Out of bounds Operation", "Minor Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (exception is InvalidOperationException)
            {
                MessageBox.Show("Operation not valid due to state of Class ", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (exception is OverflowException)
            {
                MessageBox.Show("Expression resulted in overflow", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (exception is OutOfMemoryException)
            {
                MessageBox.Show("Program has run out of memory", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (exception is StackOverflowException)
            {
                MessageBox.Show("CPU stack overflowed", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (exception is TimeoutException)
            {
                MessageBox.Show("Operation Timed Out", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





        }

    }
}
