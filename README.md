# AR-Knickknack
AR Knickknack project for CS5136 at the University of Cincinnati

<img width="694" height="1234" alt="image" src="https://github.com/user-attachments/assets/63e4c731-29cb-4dce-bb90-86b88cc41dd3" />

![shorter_demo](https://github.com/user-attachments/assets/458bffca-5267-4437-9a44-22661edaeab1)

## DEMO
Take a look at the knickknack scene yourself at this link!

https://brown5lc.github.io/ar-knickknack-web-viewer/

## Motivation
The location I chose for this project is Heublein Tower, in Simsbury Connecticut. This local landmark is significant to me, because it's one of the most recognizable landmarks from the town where I grew up. It's a stunning tower that sits on top of Talcott Mountain, built in 1914. I used to see it every other day whether it was on the way to school or the grocery store. It was an obvious choice for me for this project, because the architecture is iconic, but not overly complex, so it wasn't too far outside my 3D modeling capabilities. 

## Design
My knickknack has 5 unique models: Heublein Tower, a flock of birds, a U.S. penny, a deciduous tree, and a pine tree. The middle faces of the cube have also been given a stone brick texture to add some visual interest. Additionally, the top face of the cube has been given a grass texture to help tie everything together. 

### Heublein Tower Model: 
The Heublein Tower model was created by scratch by me, using photos of the tower as visual reference, I went through an iterative design process that started out roughly blocking out the correct shapes, and gradually added finer and finer details. I likely added more detail to the model than strictly necessary, since in practical application the model will be seen as quite small, so small details like the bell in the tower, and the frames on the windows, could easily go unnoticed. The tower is the center piece of the whole scene that everything else relates to. 

<img width="1762" height="1125" alt="Screenshot 2026-02-27 202030" src="https://github.com/user-attachments/assets/3d95bdaa-884c-4c4f-acc5-f2c4006c19da" /> <img width="1292" height="1069" alt="Screenshot 2026-02-27 230956 - Copy" src="https://github.com/user-attachments/assets/5e796909-3d4f-4c8e-b81f-f700c6f7119f" /> <img width="745" height="981" alt="Screenshot 2026-02-28 205409" src="https://github.com/user-attachments/assets/0779ffec-f585-46a8-aaee-de2871b8063a" />

### Birds Model: 
The flying birds model was one that I found on Sketchfab for free, made by user "Zacxophone". 

https://sketchfab.com/3d-models/birds-3a9bb97be78944f9bffc23fb25c2154e

I wanted to add the birds fora few reasons. Simsbury is reasonably rural, and there's nature all over the place, so it only felt right to include some wildlife. 

Additionally, I wanted to add some motion/animation to the scene, and I thought adding some flying birds around the top of the tower would be a nice way to include that. 

### U.S. Penny Model:
The Penny model was one that took me a little while to come up with. Heublein Tower is built on Talcott mountain, and on that same mountain copper was discovered in 1705, and it became the first copper mine in the United States. While the mine has long since been closed, and no modern pennies are made from copper from that mine, it's reasonable to think that pennies of the time may have been made from copper at this mine. 

I found this model on Sketchfab for free, created by user "Yanez Designs". 

https://sketchfab.com/3d-models/penny-coin-297daf2b48f24b228db4a793e6156a18

### Deciduous Tree Model:
This tree model is the second model that I modeled myself. For this one, I followed a tutorial I found on YouTube. 

https://www.youtube.com/watch?v=y7PdiGXbrD0

Note that although it claims to only take a minute, it took me quite a bit longer... 

I adjusted the color of the leaves using a "Color Ramp" node in blender, to make the leaves look more autumnal, as that fit the vibe I was going for better. 

I created two instances of this model, to help fill out the scene. One instance had slightly redder leaves, while the other has oranger leaves. 

<img width="979" height="636" alt="Screenshot 2026-03-01 191356" src="https://github.com/user-attachments/assets/ccde4f10-10bb-426e-9466-251c1041a0d6" />

<img width="1643" height="1178" alt="Screenshot 2026-03-01 193320" src="https://github.com/user-attachments/assets/29439b5e-1630-4494-bbf5-3986c73ea364" />

<img width="2539" height="1374" alt="image" src="https://github.com/user-attachments/assets/16455628-d888-40a2-8180-05baf17fa657" />

### Pine Tree Model:
The Pine Tree model was another model I found for free on Sketchfab, created by user Andriy Shekh. 

https://sketchfab.com/3d-models/pine-tree-e52769d653cd4e52a4acff3041961e65

The pine trees also contribute to the nature theme. I thought it would look too simple with only one type of tree. 

## Process

To make this knickkacnk I started out thinking about places that would be significant to me. I moved away from my home town 9 years ago, and I still miss it, so I thought it would be a nice choice. The Heublein tower stood out to me as a recognizable local landmark, and I thought it would be fairly easy to model. 

Once I decided the location and main subject, I had to decide on the overall composition. My home town has a lot of nature, so I know I wanted to rely on a nature theme. Eventually, I had a rough mockup of what I thought would look good. 

<img/>

I started by finding the 3 online models, then I spent quite a long time modeling the tower itself, and finally I modeled the second tree. 

## Challenges and Future Work

There were many challenges along the way, I would say the most significant was texturing. I had never really done texturing before, and it was an intimidating proccess. After making my own models, I thought it would be as easy as applying a texture, however, you have to correctly UV unwrap models in order for textures to apply correctly. 

<insert unwrapped tower here> 

And even once I had unwrapped, the textures were complex and had multiple layers that needed to be connected in a node menu. 

After all this complexity, when I took my models from Blender to Unity, the textures dissapeared... This was very frustrating. I found out that unless you bake a model, the textures will not be included when exporting, and they need to be reapplied once in Unity. 

Thankfully, although tedious, it wasn't as complicated in Unity, after working with the textures in Blender. 

## Use of AI and Collaboration

I did use AI to help guide me through using Blender and Unity when I could not find the information I needed easily through tutorials. 

I also worked with classmates to support one another whenever one of us was having an issue. 

## Video Demo


