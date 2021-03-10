DddResourceBuilder.new
  .init
  .resource_key('action:bank:sell-house|sell-hotel')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
