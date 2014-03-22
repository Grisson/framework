﻿// Accord Math Library
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2014
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace Accord.Math.Optimization
{
    using System;

    /// <summary>
    ///   Common interface for function optimization methods.
    /// </summary>
    /// 
    /// <seealso cref="BroydenFletcherGoldfarbShanno"/>
    /// <seealso cref="ConjugateGradient"/>
    /// <seealso cref="ResilientBackpropagation"/>
    /// <seealso cref="GoldfarbIdnaniQuadraticSolver"/>
    /// 
    public interface IOptimizationMethod
    {

        /// <summary>
        ///   Gets the solution found, the values of the parameters which
        ///   optimizes the function.
        /// </summary>
        /// 
        double[] Solution { get; }



        /// <summary>
        ///   Finds the minimum value of a function. The solution vector
        ///   will be made available at the <see cref="Solution"/> property.
        /// </summary>
        /// 
        /// <param name="values">The initial guess values for the parameters.
        ///   If the algorithm converges, this vector will contain the best 
        ///   solution found during optimization.</param>
        /// 
        /// <returns>The minimum value of the function  over its parameter
        ///   range. The solution vector that produces this minimum value 
        ///   will be available in the <see cref="Solution"/> property.</returns>
        ///  
        double Minimize(double[] values);

        /// <summary>
        ///   Finds the minimum value of a function, without throwing exceptions.
        ///   The solution vector will be made available at the <see cref="Solution"/>
        ///   property.
        /// </summary>
        /// 
        /// <param name="values">The initial guess values for the parameters.
        ///   If the algorithm converges, this vector will contain the best 
        ///   solution found during optimization.</param>
        /// 
        /// <returns>True, if the solution converged within the selected tolerance
        ///   value, false otherwise.</returns>
        ///  
        bool TryMinimize(double[] values);

    }
}
