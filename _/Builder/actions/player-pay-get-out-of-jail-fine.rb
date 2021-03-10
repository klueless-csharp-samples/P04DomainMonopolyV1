DddResourceBuilder.new
  .init
  .resource_key('action:player:pay-get-out-of-jail-fine')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
