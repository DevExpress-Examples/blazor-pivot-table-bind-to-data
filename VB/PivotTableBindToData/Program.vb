Imports Microsoft.AspNetCore.Components
Imports Microsoft.AspNetCore.Components.Web
Imports Microsoft.EntityFrameworkCore

' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ';'
' Configure the HTTP request pipeline.
' TODO: Error SkippedTokensTrivia 'if'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia '{'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
 ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
var builder = WebApplication.CreateBuilder(args);

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddRazorPages' at character 276
''' 
''' 
''' Input:
''' 
// Add services to the container.
builder.Services.AddRazorPages
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 306
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddServerS...' at character 310
''' 
''' 
''' Input:
''' builder.Services.AddServerSideBlazor
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 346
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddDevExpr...' at character 350
''' 
''' 
''' Input:
''' builder.Services.AddDevExpressBlazor
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 386
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddSinglet...' at character 390
''' 
''' 
''' Input:
''' builder.Services.AddSingleton<PivotTableBindToData.Data.WeatherForecastService>
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 469
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddDbConte...' at character 473
''' 
''' 
''' Input:
''' builder.Services.AddDbContextFactory<PivotTableBindToData.Northwind.NorthwindContext>
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '((sp, options) ' at character 558
''' 
''' 
''' Input:
''' ((sp, options) => {

'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''     var env = sp.GetRequiredService<IWebHostEnvironment>();

'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''     var dbPath = Path.Combine(env.ContentRootPath, "Northwind.db");

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'options.UseSqlite' at character 710
''' 
''' 
''' Input:
'''     options.UseSqlite
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 727
''' 
''' 
''' Input:
''' ("Data Source=" + 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'dbPath' at character 745
''' 
''' 
''' Input:
''' dbPath);
});

'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
var app = builder.Build();

// Configure the HTTP request pipeline.
if 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 830
''' 
''' 
''' Input:
''' (!
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.Environment.IsDevelopment' at character 832
''' 
''' 
''' Input:
''' app.Environment.IsDevelopment
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 861
''' 
''' 
''' Input:
''' ())
{

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseExceptionHandler' at character 871
''' 
''' 
''' Input:
'''     app.UseExceptionHandler
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 894
''' 
''' 
''' Input:
''' ("/Error");

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseHsts' at character 1042
''' 
''' 
''' Input:
'''     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1053
''' 
''' 
''' Input:
''' ();
}

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseHttpsRedirection' at character 1059
''' 
''' 
''' Input:
''' app.UseHttpsRedirection
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1082
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseStaticFiles' at character 1087
''' 
''' 
''' Input:
''' 
app.UseStaticFiles
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1105
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseRouting' at character 1110
''' 
''' 
''' Input:
''' 
app.UseRouting
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1124
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.MapBlazorHub' at character 1130
''' 
''' 
''' Input:
''' 

app.MapBlazorHub
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1146
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.MapFallbackToPage' at character 1150
''' 
''' 
''' Input:
''' app.MapFallbackToPage
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 1171
''' 
''' 
''' Input:
''' ("/_Host");

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.Run' at character 1184
''' 
''' 
''' Input:
''' 
app.Run
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1191
''' 
''' 
''' Input:
''' ();

''' 