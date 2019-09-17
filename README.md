# XamarinDocs


In Listview you can add animations for viewcells by adding Viewcell appearing eventhandler

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="Track.Views.NewFolder.ListAnimation">
    <ContentPage.Content>
        <StackLayout>
            <ListView HasUnevenRows="True" x:Name="list" BackgroundColor="Blue" >
                <ListView.ItemTemplate>
                    <DataTemplate>
                        <ViewCell x:Name="vc" Appearing="vc_Appearing">
                            <Frame BackgroundColor="Red">
                                <StackLayout>
                                    <Label Text="Hi from xamarin forms "></Label>
                                    <Label Text="Hi from xamarin forms "></Label>
                                    <Label Text="Hi from xamarin forms "></Label>
                                    <Label Text="Hi from xamarin forms "></Label>

                                </StackLayout>
                            </Frame>
                        </ViewCell>
                    </DataTemplate>
                </ListView.ItemTemplate>
            </ListView>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>



.Cs File

   private async void vc_Appearing(object sender, EventArgs e)
        {
            try
            {
                var viewCell = (ViewCell)sender;
                await viewCell.View.TranslateTo(150, 0, 7, Easing.SinIn);
                await viewCell.View.TranslateTo(0,0);
            }
            catch (Exception ex)
            {


            }

        }



Creating signing certificate for UWP apps 

 

1.Run the below script to generate certificate: 

New-SelfSignedCertificate -Type Custom -Subject "CN=Contoso Software, O=Contoso Corporation, C=US" -KeyUsage DigitalSignature -FriendlyName "Your friendly name goes here" -CertStoreLocation "Cert:\CurrentUser\My" -TextExtension @("2.5.29.37={text}1.3.6.1.5.5.7.3.3", "2.5.29.19={text}") 

 

Replace 1. C: with your company details  

2. friendly name goes here: your company name.  

 

2.VS will automatically select while generating app packages for UWP app. 

3.follow the instructions giving by vs while signing here after. 
