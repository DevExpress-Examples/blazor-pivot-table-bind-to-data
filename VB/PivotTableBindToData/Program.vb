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
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' 
''' var builder = WebApplication.CreateBuilder(args);
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddRazorPages' at character 285
''' 
''' 
''' Input:
''' 
''' // Add services to the container.
''' builder.Services.AddRazorPages
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 315
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddServerS...' at character 320
''' 
''' 
''' Input:
''' builder.Services.AddServerSideBlazor
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 356
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddDevExpr...' at character 361
''' 
''' 
''' Input:
''' builder.Services.AddDevExpressBlazor
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 397
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddSinglet...' at character 402
''' 
''' 
''' Input:
''' builder.Services.AddSingleton<PivotTableBindToData.Data.WeatherForecastService>
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 481
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddDbConte...' at character 486
''' 
''' 
''' Input:
''' builder.Services.AddDbContextFactory<PivotTableBindToData.Northwind.NorthwindContext>
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '((sp, options) ' at character 571
''' 
''' 
''' Input:
''' ((sp, options) => {
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''     var env = sp.GetRequiredService<IWebHostEnvironment>();
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
'''     var dbPath = Path.Combine(env.ContentRootPath, "Northwind.db");
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'options.UseSqlite' at character 726
''' 
''' 
''' Input:
'''     options.UseSqlite
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 743
''' 
''' 
''' Input:
''' ("Data Source=" + 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'dbPath' at character 761
''' 
''' 
''' Input:
''' dbPath);
''' });
''' 
'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 852
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\NodesVisitor.cs:line 451
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in C:\builds\CS2VB\CodeConverter-master\CodeConverter\VB\CommentConvertingVisitorWrapper.cs:line 26
''' 
''' Input:
''' 
''' var app = builder.Build();
''' 
''' // Configure the HTTP request pipeline.
''' if 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 852
''' 
''' 
''' Input:
''' (!
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.Environment.IsDevelopment' at character 854
''' 
''' 
''' Input:
''' app.Environment.IsDevelopment
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 883
''' 
''' 
''' Input:
''' ())
''' {
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseExceptionHandler' at character 895
''' 
''' 
''' Input:
'''     app.UseExceptionHandler
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 918
''' 
''' 
''' Input:
''' ("/Error");
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseHsts' at character 1068
''' 
''' 
''' Input:
'''     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
'''     app.UseHsts
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1079
''' 
''' 
''' Input:
''' ();
''' }
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseHttpsRedirection' at character 1087
''' 
''' 
''' Input:
''' app.UseHttpsRedirection
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1110
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseStaticFiles' at character 1117
''' 
''' 
''' Input:
''' 
''' app.UseStaticFiles
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1135
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseRouting' at character 1142
''' 
''' 
''' Input:
''' 
''' app.UseRouting
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1156
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.MapBlazorHub' at character 1165
''' 
''' 
''' Input:
''' 
''' 
''' app.MapBlazorHub
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1181
''' 
''' 
''' Input:
''' ();
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.MapFallbackToPage' at character 1186
''' 
''' 
''' Input:
''' app.MapFallbackToPage
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 1207
''' 
''' 
''' Input:
''' ("/_Host");
''' 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.Run' at character 1222
''' 
''' 
''' Input:
''' 
''' app.Run
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 1229
''' 
''' 
''' Input:
''' ();
''' 
''' 