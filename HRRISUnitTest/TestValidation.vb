Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports s3575643_Assignment01_HRRIS.Validation

' Name: TestValidation.vb
' Description: Class for testing Validation class
' Author: Nguyen Anh Hoang Phuong
' Date: 08/05/2017


<TestClass()> Public Class TestValidation

    <TestInitialize()> Public Sub setup()
        Debug.Print("Setting up ...")
    End Sub

    <TestCleanup()> Public Sub cleanup()
        Debug.Print("Cleaning up ...")
    End Sub

    <TestMethod()> Public Sub TestIsAlpha1()
        Dim oValidation As New s3575643_Assignment01_HRRIS.Validation
        Dim sAlpha = "drrt"
        Assert.AreEqual(True, oValidation.isAlpha(sAlpha))
    End Sub

    <TestMethod()> Public Sub TestIsAlpha2()
        Dim oValidation As New s3575643_Assignment01_HRRIS.Validation
        Dim sAlpha = "123"
        Assert.AreEqual(False, oValidation.isAlpha(sAlpha))
    End Sub

    <TestMethod()> Public Sub TestIsAlphaNumericVal1()
        Dim oValidation As New s3575643_Assignment01_HRRIS.Validation
        Dim sAlphaNumeric = "drrt"
        Assert.AreEqual(False, oValidation.isAlphaNumericVal(sAlphaNumeric))
    End Sub

    <TestMethod()> Public Sub TestIsAlphaNumericVal2()
        Dim oValidation As New s3575643_Assignment01_HRRIS.Validation
        Dim sAlphaNumeric = "123"
        Assert.AreEqual(False, oValidation.isAlphaNumericVal(sAlphaNumeric))
    End Sub

    <TestMethod()> Public Sub TestIsAlphaNumericVal3()
        Dim oValidation As New s3575643_Assignment01_HRRIS.Validation
        Dim sAlphaNumeric1 = "abc123"
        Dim sAlphaNumeric2 = "123abc"
        Assert.AreEqual(True, oValidation.isAlphaNumericVal(sAlphaNumeric1))
        Assert.AreEqual(True, oValidation.isAlphaNumericVal(sAlphaNumeric2))
    End Sub

    <TestMethod()> Public Sub TestIsEmail1()
        Dim oValidation As New s3575643_Assignment01_HRRIS.Validation
        Dim sAlphaNumeric = "serg32w6532q"
        Assert.AreEqual(False, oValidation.isEmail(sAlphaNumeric))
    End Sub

    <TestMethod()> Public Sub TestIsEmail2()
        Dim oValidation As New s3575643_Assignment01_HRRIS.Validation
        Dim sAlphaNumeric = "abc123@g.com"
        Assert.AreEqual(True, oValidation.isEmail(sAlphaNumeric))
    End Sub
End Class