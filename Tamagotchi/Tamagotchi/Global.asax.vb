﻿Imports System.Web.Routing

Public Class Global_asax
    Inherits HttpApplication

    Sub Application_Start(sender As Object, e As EventArgs)
        RegisterRoutes(RouteTable.Routes)
        ' É acionado quando o aplicativo é iniciado
    End Sub

    Shared Sub RegisterRoutes(routes As RouteCollection)

        routes.MapPageRoute("petname",
        "{petname}",
        "~/TamagotchiPage.aspx",
        False)
    End Sub
End Class